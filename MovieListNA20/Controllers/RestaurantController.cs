using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieListNA20.Models;
using MovieListNA20.Models.ViewModels;
using MovieListNA20.Services;
using MovieListNA20.ViewModels;

namespace MovieListNA20.Controllers
{
    public class RestaurantController : Controller
    {
        private IRestaurantData _restaurantData;

        public RestaurantController(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }
        public IActionResult Index()
        {
            var model = new RestaurantIndexViewModel();
            model.Restaurants = _restaurantData.GetAll();
            model.CurrentMessage = "Måndag";

            return View(model);
        }

        public IActionResult details(int id)
        {
            var model = _restaurantData.Get(id);
            if(model == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult create(RestaurantEditModel  model)
        {
            var newRestaurant = new Restaurant();
            newRestaurant.Name = model.Name;
            newRestaurant.Cuisine = model.Cuisine;
            newRestaurant = _restaurantData.add(newRestaurant);

            return RedirectToAction("details", new { id = newRestaurant.Id });
        }
    }

   
}