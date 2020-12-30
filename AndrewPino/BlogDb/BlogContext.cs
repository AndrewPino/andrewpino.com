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
        
        public DbSet<Tag> Tags { get; set; }
        
        public DbSet<BlogTag> BlogTags { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>()
                .HasMany(bt => bt.BlogTags)
                .WithOne(bt => bt.Blog)
                .HasPrincipalKey(b => b.BlogId)
                .HasForeignKey(bt => bt.BlogId);

            modelBuilder.Entity<BlogComment>()
                .HasOne(bc => bc.Blog)
                .WithMany(b => b.BlogComments)
                .HasForeignKey(bc => bc.BlogId);

            modelBuilder.Entity<Tag>()
                .HasMany(t => t.BlogTags)
                .WithOne(bt => bt.Tag)
                .HasPrincipalKey(t => t.TagId)
                .HasForeignKey(bt => bt.TagId);
        }
    }
}