using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LOLEMCosmetics.Models;
using LOLEMCosmetics.Models.ViewModels;

namespace LOLEMCosmetics.Controllers
{
    public class HomeController : Controller
    {
        private ILOLEMCosmeticsRepository repository;
        public int PageSize = 3;
        public HomeController(ILOLEMCosmeticsRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index(string genre, int LOLEMPage = 1)
  => View(new LOLEMListViewModel
  {
      LOLEMs = repository.LOLEMs
     .Where(p => genre == null || p.Genre == genre)
           .OrderBy(p => p.LOLEMID)
           .Skip((LOLEMPage - 1) * PageSize)
           .Take(PageSize),
      PagingInfo = new PagingInfo
      {
          CurrentPage = LOLEMPage,
          ItemsPerPage = PageSize,
          TotalItems = genre == null ?
 repository.LOLEMs.Count() :
 repository.LOLEMs.Where(e =>
 e.Genre == genre).Count()
      },
      CurrentGenre = genre
  });

    }
}
