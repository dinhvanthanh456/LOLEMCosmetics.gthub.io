using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LOLEMCosmetics.Models;
namespace LOLEMCosmetics.ViewComponents
{
    public class GenreNavigation : ViewComponent
    {
        private ILOLEMCosmeticsRepository repository;
        public GenreNavigation(ILOLEMCosmeticsRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedGenre = RouteData?.Values["genre"];
            return View(repository.LOLEMs
            .Select(x => x.Genre)
            .Distinct()
            .OrderBy(x => x));
        }
    }
}