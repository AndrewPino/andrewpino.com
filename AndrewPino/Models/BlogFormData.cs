using Microsoft.AspNetCore.Http;

namespace AndrewPino.Models
{
    public class BlogFormData
    {
        public string Title { get; set; }
        
        public string Body { get; set; }
        
        public IFormFile Image { get; set; }
        
        public string BlogTags { get; set; }
    }
}