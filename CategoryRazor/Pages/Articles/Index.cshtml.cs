using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CategoryRazor.Data;
using CategoryRazor.Models;

namespace TestRazorApp.Pages.Articles
{
    public class IndexModel : PageModel
    {
        private readonly BlogDbContext _context;

        public IndexModel(BlogDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Article> Articles { get; set; }
        public void OnGet()
        {
            Articles = _context.Articles;
        }
    }
}
