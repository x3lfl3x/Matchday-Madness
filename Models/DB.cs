using LinqToTwitter;
using Microsoft.EntityFrameworkCore;

namespace MatchdayMadness2.Models
{
    public class DB : DbContext
    {
        public DB(DbContextOptions<DB> context) : base(context) 
        {

        }
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
             optionsBuilder.UseSqlServer("Data Source=DESKTOP-10KAPP9;Integrated Security=True;Database=MatchdayMadness3;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
             optionsBuilder.UseLazyLoadingProxies();
         }
        */
        public DbSet<Players> Players { get; set; }
        public DbSet<Teams> Teams { get; set; }
        public DbSet<Favorites> Favorites {  get; set; }

    }
}
