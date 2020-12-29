using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AndrewPino.BlogDb;
using AndrewPino.BlogDb.DataModels;
using AndrewPino.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AndrewPino.Controllers
{
    public class BlogController : Controller
    {
        private readonly BlogContext _context;
        
        public BlogController(BlogContext context)
        {
            _context = context;
        }
        
        public async Task<IActionResult> Index()
        {
            var blogs = await _context.Blogs
                .Include(bbt => bbt.BlogTags).ThenInclude(b => b.Tag)
                .Include(bbt => bbt.BlogComments)
                .ToListAsync();
            
            return View(blogs);
        }

        public async Task<IActionResult> Entry()
        {
            var tags = await _context.Tags.ToListAsync();
            var entry = new BlogEntry
            {
                AvailableBlogTags = tags.Select(t => new SelectListItem
                {
                    Value = t.TagId.ToString(),
                    Text = t.Text,
                    Selected = false
                }).ToList()
            };
            
            return View(entry);
        }

        [HttpPost]
        public async Task<IActionResult> EditBlog([FromForm] int blogId)
        {
            var blog = await _context.Blogs
                            .Include(b => b.BlogTags).ThenInclude(bbt => bbt.Tag)
                            .FirstOrDefaultAsync(b => b.BlogId == blogId);
            
            var tags = await _context.Tags.ToListAsync();
            var entry = new BlogEntry
            {
                Blog = blog,
                AvailableBlogTags = tags.Select(t => new SelectListItem
                {
                    Value = t.TagId.ToString(),
                    Text = t.Text,
                    Selected = blog.BlogTags.Any(bbt => bbt.TagId == t.TagId)
                }).ToList()
            };
            
            return View("Entry", entry);
        }

        public async Task<IActionResult> List()
        {
            var blogs = await _context.Blogs.Select(b => new BlogItem
            {
                BlogId = b.BlogId,
                Title = b.Title,
                CreatedDate = b.CreatedDate
            }).ToListAsync();

            return View(blogs);
        }

        [HttpPost]
        public async Task<IActionResult> Submission([FromForm] BlogFormData blogFormData)
        {
            Blog blog;
            if (blogFormData.BlogId.HasValue)
            {
                blog = new Blog
                {
                    BlogId = blogFormData.BlogId.Value,
                    Title = blogFormData.Title,
                    Body = blogFormData.Body,
                    ImageUrl = await HandleFile(blogFormData.Image)
                };
            }
            else
            {
                blog = new Blog
                {
                    Title = blogFormData.Title,
                    Body = blogFormData.Body,
                    ImageUrl = await HandleFile(blogFormData.Image)
                };
            }

            blog.BlogTags = await BuildBlogTagList(blogFormData.BlogTagIds, blog);

            if (blogFormData.BlogId.HasValue)
            {
                _context.Blogs.Update(blog);
            }
            else
            {
                await _context.Blogs.AddAsync(blog);
            }
            
            await _context.SaveChangesAsync();
            
            return View(blog);
        }

        private async Task<List<BlogTag>> BuildBlogTagList(List<int> blogTagIds, Blog blog)
        {
            if (blogTagIds == null || blogTagIds.Count == 0) 
                return Enumerable.Empty<BlogTag>().ToList();

            var existingTags = await _context.Tags.ToListAsync();

            var usedTags = existingTags.Where(et => blogTagIds.Contains(et.TagId));

            var blogBlogTags = 
                usedTags.Select(tag => new BlogTag
                {
                    Blog = blog,
                    Tag = tag
                }).ToList();

            return blogBlogTags;
        }

        private async Task<string> HandleFile(IFormFile file)
        {
            if (file == null || file.Length == 0) return String.Empty;

            var splitFileName = file.FileName.Split('.', StringSplitOptions.RemoveEmptyEntries);
            var newFileName = String.Join("", 
                String.Join("", splitFileName.Take(splitFileName.Length - 1)), "_",
                (new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds()).ToString(), ".", splitFileName.Last());
            
            var filePath = $"/var/www/andrewpino-com-images/blog/{newFileName}";

            await using var stream = new FileStream(filePath, FileMode.Create);
            await file.CopyToAsync(stream);
            
            return newFileName;
        }
    }
}