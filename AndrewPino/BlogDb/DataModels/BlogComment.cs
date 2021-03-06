using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndrewPino.BlogDb.DataModels
{
    [Table("BlogComment")]
    public class BlogComment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CommentId { get; set; }
        
        public string Text { get; set; }
        
        public string Author { get; set; }
        
        public int BlogId { get; set; }
        
        public virtual Blog Blog { get; set; }
    }
}