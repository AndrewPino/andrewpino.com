using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace AndrewPino.Models
{
    public class BlogFormData
    {
        public string Title { get; set; }
        
        public string Body { get; set; }
        
        public IFormFile Image { get; set; }
        
        public List<int> BlogTagIds { get; set; }
    }
}