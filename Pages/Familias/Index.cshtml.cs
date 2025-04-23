using crudwebventas1.Data;
using crudwebventas1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class IndexModel : PageModel
    {
        private readonly AppDbCOntext _ctx;

        public IndexModel(AppDbCOntext ctx){
            _ctx = ctx;
        }

        public List<Familia> Familias { get; set; }
        public void OnGet()
        {
            Familias = _ctx.Familias.ToList();
        }
    }
}
