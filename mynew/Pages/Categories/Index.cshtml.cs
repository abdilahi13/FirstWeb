using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using mynew.Data;
using mynew.model;

namespace mynew.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDBContext _db;
        public IEnumerable<Category> Categories { get; set; }   
        public IndexModel(ApplicationDBContext db)
        {
        _db=db;

        }

        public void OnGet()
        {
            Categories = _db.Category;
        }
    }
}
