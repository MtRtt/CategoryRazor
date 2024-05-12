using CategoryRazor.Models;
using Microsoft.EntityFrameworkCore;

using System.Drawing;

namespace CategoryRazor.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {
        }
        public DbSet<Article> Articles { get; set; }
    }
}

