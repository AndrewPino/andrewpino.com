using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndrewPino.BlogDb.DataModels
{
    [Table("Blog")]
    public class Blog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BlogId { get; set; }
        
        public string Title { get; set; }
        
        public string Body { get; set; }
        
        public string ImageUrl { get; set; }

        public DateTime CreatedDate => DateTime.Now;
        
        public virtual List<BlogTag> BlogTags { get; set; }
        
        public virtual List<BlogComment> BlogComments { get; set; }
    }
}