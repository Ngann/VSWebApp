using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {

        // The Id field which is required by the database for the primary key.

        public int Id { get; set; }
        public string Title { get; set; }


        //The Display attribute specifies what to display for the name of a field(in this case "Release Date" instead of "ReleaseDate").
        [Display(Name = "Release Date")]
        
        //The DataType attribute specifies the type of the data (Date). With this attribute:
        //The user is not required to enter time information in the date field.
        //Only the date is displayed, not time information
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }


        //data annotation is required so Entity Framework Core can correctly map Price to currency in the database.
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

    }
}
