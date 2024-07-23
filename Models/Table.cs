using System.Reflection.Metadata.Ecma335;

namespace MatchdayMadness2.Models
{
    public class Table
    {
        public int id { get; set; }
        public string LeagueName { get; set; }
        public string Teams { get; set; }
        public string Standings { get; set; }
    }
}
