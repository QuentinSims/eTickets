using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Actor_Movie
    {

        [ForeignKey("MovieId")]
        public int MovieId { get; set; }

        //relationship
        public Movie Movie { get; set; }


        [ForeignKey("ActorId")]
        public int ActorId { get; set; }

        //relationship
        public Actor Actor { get; set; }

    }
}
