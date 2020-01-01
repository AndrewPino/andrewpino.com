using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndrewPino.BlogDb.DataModels
{
    [Table("BlogBlogTag")]
    public class BlogBlogTag
    {
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
        
        public int BlogTagId { get; set; }
        public BlogTag BlogTag { get; set; }
    }
}