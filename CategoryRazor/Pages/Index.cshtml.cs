using CategoryRazor.Data;
using CategoryRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CategoryRazor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly BlogDbContext _db;
        public IndexModel( BlogDbContext db)
        {
            _db = db;
            
        }


        public IEnumerable<Article> Articles { get; set; }

        public void OnGet()
        {
            Articles = _db.Articles;
        }
    }
}
