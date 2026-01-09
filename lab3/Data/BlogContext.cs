using Microsoft.EntityFrameworkCore;
using lab3.Models.Entities;

namespace lab3.Data
{
    public class BlogContext : DbContext
    {
        public DbSet<BlogArticle> Articles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=blog.db");
        }
    }
}