﻿namespace GroupManager.Data.Models
{
    public sealed class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surename { get; set; }

        public string City { get; set; }

        public string ProfilePictureUrl { get; set; }

        public User()
        {
            Name = string.Empty;
            Surename = string.Empty;
            City = string.Empty;
            ProfilePictureUrl = string.Empty;
        }
    }
}