using Movies.Data.Maps;
using Movies.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Data
{
    public class MovieDatabaseContext : DbContext
    {
        public MovieDatabaseContext() : base("MovieDb")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MovieDatabaseContext>());
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MovieMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
