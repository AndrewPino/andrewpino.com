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
        
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
        
        public int TagId { get; set; }
        public virtual Tag Tag { get; set; }
    }
}