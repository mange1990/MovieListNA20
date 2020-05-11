using MovieListNA20.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieListNA20.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> _restaurants;

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant{Id = 1, Name = "Magnus Pizza"},
                new Restaurant{Id = 2, Name = "Kebab stället"},
                new Restaurant{Id = 3, Name = "hamburgare burger king"}
            };
        }

        public Restaurant add(Restaurant restaurant)
        {
            restaurant.Id = _restaurants.Max(r => r.Id) + 1;
            _restaurants.Add(restaurant);
            return restaurant;
        }

        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(r => r.Id == id);

        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(n => n.Name);
        }
    }
}
