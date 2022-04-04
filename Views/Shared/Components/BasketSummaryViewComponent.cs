using Microsoft.AspNetCore.Mvc;
using PBBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PBBookStore.Views.Shared.Components
{
    public class BasketSummaryViewComponent : ViewComponent
    {
        private Basket basket;

        public BasketSummaryViewComponent (Basket basketService)
        {
            basket = basketService;
        }

        public IViewComponentResult Invoke()
        {
            return View(basket);
        }
    }
}
