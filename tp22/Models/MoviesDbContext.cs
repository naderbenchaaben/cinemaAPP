using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace tp22.Models
{
    public class MoviesDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor>Actors { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Participation> Participations { get; set; }
    }
}