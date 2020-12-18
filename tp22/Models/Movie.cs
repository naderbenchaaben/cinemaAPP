using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tp22.Models
{
    public class Movie
    {
        public int ID { get; set; }

        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }

        public int DirectorID { get; set; }
        public virtual Director Director { get; set; }
        public virtual ICollection<Participation> Participations { get; set; }




    }
}