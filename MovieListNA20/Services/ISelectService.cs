using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieListNA20.Services
{
    public interface ISelectService
    {
        Task<IEnumerable<SelectListItem>> GetSelectAsync();
    }
}