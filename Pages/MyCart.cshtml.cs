using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LOLEMCosmetics.MyTagHelper;
using LOLEMCosmetics.Models;
using System.Linq;
namespace LOLEMCosmetics.Pages
{
    public class MyCartModel : PageModel
    {
        private ILOLEMCosmeticsRepository repository;
        public MyCartModel(ILOLEMCosmeticsRepository repo, MyCart myCartService)
        {
            repository = repo;
            myCart = myCartService;
        }
        public MyCart myCart { get; set; }
        public string ReturnUrl { get; set; }
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }
        public IActionResult OnPost(long LOLEMId, string returnUrl)
        {
            LOLEM LOLEM = repository.LOLEMs
            .FirstOrDefault(b => b.LOLEMID == LOLEMId);
            myCart.AddItem(LOLEM,
                           1);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
        public IActionResult OnPostRemove(long LOLEMId, string returnUrl)
        {
            myCart.RemoveLine(myCart.Lines.First(cl =>
            cl.LOLEM.LOLEMID == LOLEMId).LOLEM);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}