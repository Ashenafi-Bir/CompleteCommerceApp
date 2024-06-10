using AshCommerce.Data.Base;
using AshCommerce.Models;

namespace AshCommerce.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        //Task<Movie> GetMovieByIdAsync(int id);
        //Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        //Task AddNewMovieAsync(NewMovieVM data);
        //Task UpdateMovieAsync(NewMovieVM data);
    }
}
