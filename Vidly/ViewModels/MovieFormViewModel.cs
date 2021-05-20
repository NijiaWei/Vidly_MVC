using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {

        //Genre
        public IEnumerable<Genre> Genres { get; set; }
        
        //Movie Id - Instead of using New Movie that enables Id to be nullable as assigning it with 0 value
        public int? Id { get; set; }



        //For creating a new movie
        public MovieFormViewModel()
        {
            Id = 0;
        } // default constructor
       


        //For editing page
        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }//overload


        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
        }



        // Movie
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte? GenreId { get; set; }

        [Display(Name = "Release Date")]
        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        [Required]
        public byte? NumberInStock { get; set; }

       

    }
}
