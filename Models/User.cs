﻿namespace MatchdayMadness2.Models
{
    public class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string phoneNumber { get; set; }
        public DateTime dateOfBirth { get; set; }
    }
}
