using Microsoft.AspNetCore.Mvc;
using MovieListNA20.Data;
using MovieListNA20.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieListNA20.ViewComponents
{
    public class StarsViewComponent : ViewComponent
    {
        private readonly MovieListNA20Context context;

        public StarsViewComponent(MovieListNA20Context context)
        {
            this.context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int movieId)
        {
            var movie = await context.Movie.FindAsync(movieId);

            var doubleRating = (int)Math.Round(movie.Rating * 2);

            var model = new StarViewModel()
            {
                Stars = doubleRating / 2,
                IsHalfStar = doubleRating % 2 == 1
            };

            return View(model);
        }
    }
}
