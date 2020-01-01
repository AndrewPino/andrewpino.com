using AndrewPino.BlogDb.DataModels;
using Microsoft.EntityFrameworkCore;

namespace AndrewPino.BlogDb
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {
        }
        
        public DbSet<Blog> Blogs { get; set; }
        
        public DbSet<BlogComment> BlogComments { get; set; }
        
        public DbSet<BlogTag> BlogTags { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlogBlogTag>()
                .HasKey(t => new { t.BlogId, t.BlogTagId });

            modelBuilder.Entity<BlogBlogTag>()
                .HasOne(bbt => bbt.Blog)
                .WithMany(b => b.BlogBlogTags)
                .HasForeignKey(pt => pt.BlogId);

            modelBuilder.Entity<BlogBlogTag>()
                .HasOne(bbt => bbt.BlogTag)
                .WithMany(b => b.BlogBlogTags)
                .HasForeignKey(pt => pt.BlogTagId);
        }
    }
}