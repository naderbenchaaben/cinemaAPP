using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tp22.Models
{
    public class Actor
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public virtual ICollection<Participation> Participations { get; set; }
    }
}