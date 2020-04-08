using Microsoft.EntityFrameworkCore;
using Madalali.Models;

namespace Madalali.Models
{
    public class LocationContext : DbContext
    {
        public LocationContext(DbContextOptions<LocationContext> options) 
       :base(options)
        {

        }

        public DbSet<Location> Locations;

        public DbSet<Madalali.Models.Location> Location { get; set; }
    }
}