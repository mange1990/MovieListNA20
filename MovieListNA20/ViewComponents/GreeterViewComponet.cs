using System;
using Microsoft.AspNetCore.Mvc;

namespace MovieListNA20.ViewComponents
{
    public class GreeterViewComponet : ViewComponent
    {
        public GreeterViewComponet()
        {
        }

        public IViewComponentResult Invoke()
        {
            var model = "hej! Idag är det fredag";
            return View(model);
        }
    }
}
