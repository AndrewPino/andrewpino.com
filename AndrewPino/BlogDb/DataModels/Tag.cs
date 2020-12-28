using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndrewPino.BlogDb.DataModels
{
    [Table("Tag")]
    public class Tag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TagId { get; set; }
        
        public string Text { get; set; }
        
        public virtual List<BlogTag> BlogTags { get; set; }
    }
}