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
using Microsoft.EntityFrameworkCore;

namespace AndrewPino.Controllers
{
    public class BlogController : Controller
    {
        private BlogContext Context;
        
        public BlogController(BlogContext context)
        {
            Context = context;
        }
        
        public async Task<IActionResult> Index()
        {
            var blogs = await Context.Blogs
                .Include(bbt => bbt.BlogBlogTags).ThenInclude(b => b.BlogTag)
                .Include(bbt => bbt.BlogComments)
                .ToListAsync();
            
            return View(blogs);
        }

        public async Task<IActionResult> Entry()
        {
            var tags = await Context.BlogTags.ToListAsync();
            return View(tags);
        }

        [HttpPost]
        public async Task<IActionResult> Submission([FromForm] BlogFormData blogFormData)
        {
            var blog = new Blog
            {
                Title = blogFormData.Title,
                Body = blogFormData.Body,
                ImageUrl = await HandleFile(blogFormData.Image)
            };

            blog.BlogBlogTags = await BuildBlogTagList(blogFormData.BlogTagIds, blog);

            Context.Blogs.Add(blog);
            await Context.SaveChangesAsync();
            
            var tags = await Context.BlogTags.ToListAsync();
            return View("Entry", tags);
        }

        private async Task<List<BlogBlogTag>> BuildBlogTagList(List<int> blogTagIds, Blog blog)
        {
            if (blogTagIds == null || blogTagIds.Count == 0) 
                return Enumerable.Empty<BlogBlogTag>().ToList();

            var existingTags = await Context.BlogTags.ToListAsync();

            var usedTags = existingTags.Where(et => blogTagIds.Contains(et.BlogTagId));

            var blogBlogTags = 
                usedTags.Select(tag => new BlogBlogTag
                {
                    Blog = blog,
                    BlogTag = tag
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
            
            var filePath = "/websites/andrewpino.com.images/blog/" + newFileName;
            
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return newFileName;
        }
    }
}