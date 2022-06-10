﻿using Microsoft.AspNetCore.Mvc;
using LOLEMCosmetics.Models;
namespace LOLEMCosmetics.ViewComponents
{
    public class CartSummary : ViewComponent
    {
        private MyCart cart;
        public CartSummary(MyCart cartService)
        {
            cart = cartService;
        }
        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}
