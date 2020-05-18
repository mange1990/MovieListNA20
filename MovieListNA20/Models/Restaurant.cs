using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieListNA20.Models
{
    public class Restaurant
    {
        public int Id { get; set; }

        [Display(Name = "Restaurantname")]
        [Required, MaxLength(30)]
        public string Name { get; set; }



        public CuisineType Cuisine { get; set; }


    }
}
