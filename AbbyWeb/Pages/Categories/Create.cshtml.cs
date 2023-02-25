using AbbyWeb.Data;
using AbbyWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Categories
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDBContext _db;

        //[BindProperty]
        public Category Category { get; set; }

        public CreateModel(ApplicationDBContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            await _db.Categories.AddAsync(Category);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
