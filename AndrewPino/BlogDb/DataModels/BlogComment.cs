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
        
        public string CommentText { get; set; }
        
        public string Author { get; set; }
        
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}