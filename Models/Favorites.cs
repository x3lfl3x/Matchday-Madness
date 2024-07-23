using LinqToTwitter;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MatchdayMadness2.Models
{
    public class Favorites
    {
        // public List<Players> FavoritePlayers { get; set; } = new List<Players>();
        //public List<Teams> FavoriteTeams { get; set; } = new List<Teams>();
        [Key]
        public int id { get; set; }
        public string FavoriteTeam { get; set; }
        public string FavoritePlayer { get; set; }
        
        [ForeignKey("Teams")]
        public int?  Team_ID { get; set; }
        public virtual Teams Teams { get; set; }
    }
}
