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
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Entry()
        {
            return View();
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

            blog.BlogBlogTags = await ParseBlogTags(blogFormData.BlogTags, blog);

            Context.Blogs.Add(blog);
            await Context.SaveChangesAsync();
            
            return View("Entry");
        }

        private async Task<List<BlogBlogTag>> ParseBlogTags(string formTags, Blog blog)
        {
            if (formTags == null || formTags.Trim() == String.Empty) 
                return Enumerable.Empty<BlogBlogTag>().ToList();

            var existingTags = await Context.BlogTags.ToListAsync();

            var formTagList = formTags.Split(';', StringSplitOptions.RemoveEmptyEntries)
                .Select(t => t.Trim()).ToList();

            var blogBlogTags = existingTags.Where(existingTag => formTagList.Contains(existingTag.TagText))
                .Select(tag => new BlogBlogTag
                {
                    Blog = blog,
                    BlogTag = tag
                }).ToList();

            return blogBlogTags;
        }

        private async Task<string> HandleFile(IFormFile file)
        {
            if (file == null || file.Length == 0) return String.Empty;
            
            var fileName = file.FileName + "__" + (new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds()).ToString();
            var filePath = "/websites/andrewpino.com.blogimages/" + fileName;
 
            var logFile = System.IO.File.Create(filePath);
            var logWriter = new System.IO.StreamWriter(logFile);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return fileName;
        }
    }
}