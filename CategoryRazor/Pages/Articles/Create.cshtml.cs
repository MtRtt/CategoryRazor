using CategoryRazor.Data;
using CategoryRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CategoryRazor.Pages.Articles
{
    public class CreateModel : PageModel
    {
        private readonly BlogDbContext _db;

        public CreateModel(BlogDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Article Article { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost() 
        {
            await _db.Articles.AddAsync(Article);
            await _db.SaveChangesAsync();
            return RedirectToPage("/Index");
        }
    }
}
