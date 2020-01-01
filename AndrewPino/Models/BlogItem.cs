using System;

namespace AndrewPino.Models
{
    public class BlogItem
    {
        public int BlogId { get; set; }
        
        public string Title { get; set; }
        
        public DateTime CreatedDate { get; set; }
        
        public bool IsDeleted { get; set; }
    }
}