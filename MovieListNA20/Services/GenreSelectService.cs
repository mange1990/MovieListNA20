using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieListNA20.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieListNA20.Services
{
    public class GenreSelectService : ISelectService
    {
        private readonly MovieListNA20Context db;

        public GenreSelectService(MovieListNA20Context db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<SelectListItem>> GetSelectAsync()
        {
            return await db.Movie
                .Select(m => m.Genre)
                .Distinct()
                .Select(m => new SelectListItem
                {
                    Text = m.ToString(),
                    Value = m.ToString()
                })
                .ToListAsync();
        }
    }
}
