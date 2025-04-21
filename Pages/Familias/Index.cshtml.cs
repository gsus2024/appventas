using appventas.Data;
using appventas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _ctx;

        public IndexModel(AppDbContext ctx)
        {
            this._ctx = ctx;
        }

        public List<Familia> Familias{ get; set; }
        public void OnGet()
        {
            Familias=_ctx.Familias.ToList();
        }
    }
}
