using eTickets.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Movie
    {
        //entity framework - identifier
        [Key]
        public int Id { get; set; }


        [Display(Name = "Movie name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Price")]
        public double Price { get; set; }

        [Display(Name = "Movie Category")]
        public MovieCategory MovieCategory { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }


        //relationships
        public List<Actor_Movie> Actors_Movies { get; set; }

        //Cinema

        [ForeignKey("CinemaId")]
        public int CinemaId { get; set; }

        public Cinema Cinema { get; set; }


        //Producer

        [ForeignKey("ProducerId")]
        public int ProducerId { get; set; }

        public Producer Producer { get; set; }
    }
}
