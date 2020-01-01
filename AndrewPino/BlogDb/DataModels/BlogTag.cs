using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndrewPino.BlogDb.DataModels
{
    [Table("BlogTag")]
    public class BlogTag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BlogTagId { get; set; }
        
        public string TagText { get; set; }
        
        public List<BlogBlogTag> BlogBlogTags { get; set; }
    }
}