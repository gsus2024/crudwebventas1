using crudwebventas1.Data;
using crudwebventas1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class CreateModel : PageModel
    {
        private readonly AppDbCOntext _ctx;

        public CreateModel(AppDbCOntext ctx){
            _ctx = ctx;
        }
        [BindProperty]
        public Familia Familia { get; set; }
        public IActionResult OnPost()
        {
            _ctx.Familias.Add(Familia);
            _ctx.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
