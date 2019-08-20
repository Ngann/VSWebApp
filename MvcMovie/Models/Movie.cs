using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {

        // The Id field which is required by the database for the primary key.

        public int Id { get; set; }
        public string Title { get; set; }


        //The DataType attribute specifies the type of the data (Date). With this attribute:
        //The user is not required to enter time information in the date field.
        //Only the date is displayed, not time information

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }

    }
}
