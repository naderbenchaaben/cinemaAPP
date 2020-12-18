using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tp22.Models
{
    public class Director
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public virtual ICollection<Movie>Movies { get; set; }
    }
}