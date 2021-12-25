using Microsoft.AspNetCore.Mvc;
using SinemaAppWeb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinemaAppWeb.ViewComponents
{
    public class CategoryMenuViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            if (RouteData.Values["action"].ToString()=="Index")
            {
                    ViewBag.SelectedCategory = RouteData?.Values["id"];
            }
            
            return View(CategoryRepository.Categories);
        }
    }
}
