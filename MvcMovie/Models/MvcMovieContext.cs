using Microsoft.EntityFrameworkCore;


//PostgreSql
//namespace MvcMovie.Models
//{
//    public class MvcMovieContext : DbContext
//    {
//        public DbSet<Movie> Movie { get; set; }
//    }
//}

//Sql
namespace MvcMovie.Models
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        //creates a DbSet property for the entity set
        //In Entity Framework terminology, an entity set typically corresponds to a database table, and an entity corresponds to a row in the table.
        public DbSet<Movie> Movie { get; set; }
    }
}
