using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tp22.Models
{
    public class Participation
    {
        public int  ID { get; set; }
        public Role Role { get; set; }
        public int MovieID  { get; set; }
        public int ActorID { get; set; }
        public virtual Actor Actor { get; set; }
        public virtual Movie Movie { get; set; }
    }
}