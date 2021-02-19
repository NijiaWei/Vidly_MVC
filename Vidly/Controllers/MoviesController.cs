using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        //public ActionResult MoviesList()
        //{
        //    var moviesList = new List<Movie>
        //    {
        //        new Movie {Id = 1, Name = "Movie 1"},
        //        new Movie {Id = 2, Name = "Movie 2"}
        //    };

        //    var viewModel = new MoviesListViewModel
        //    {
        //        MoviesList = moviesList
        //    };
        //    return View(viewModel);
        //}


        // GET: Movie Rental Detail
        public ActionResult ShowMovie(int id)
        {
            int movieId = id;

            if (movieId == 1)
            {
                var movie = new Movie() { Name = "Movie 1" };
                var customersList = new List<Customer>
                    {
                        new Customer {Id = 1, Name = "Customer 1"},
                        new Customer {Id = 2, Name = "Customer 2"},
                        new Customer {Id = 3, Name = "Customer 3"}
                     };

                 var viewModel = new RandomMovieViewModel
                    {
                        Movie = movie,
                        Customers = customersList
                    }; 
                 return View(viewModel);
                      
            }
            else
            {
                var movie = new Movie() { Name = "Movie 2" };
                var customersList = new List<Customer>
                    {
                        new Customer {Id = 1, Name = "Customer 1"},
                        new Customer {Id = 4, Name = "Customer 4"},
                        new Customer {Id = 5, Name = "Customer 5"}
                     };

                var viewModel = new RandomMovieViewModel
                {
                    Movie = movie,
                    Customers = customersList
                };
                return View(viewModel);
            }

           

        }


        //eg.: return Content
        //public ActionResult Edit(int id)
        //{
        //    return Content("id=" + id);
        //}


        //navigate to movies
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";
        //    return Content(String.Format("pageIndex={0}&sortBy={1}",pageIndex, sortBy));
        //}



        //custom route
        //[Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")] //not a verbatim string
        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}
    }
}