﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication03.Models
{
    public class City
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }

        public string PostNumber { get; set; }

        public DateTime Register { get; set; }

        public Country? Country { get; set; }

        public List<Person> People { get; set; } = new List<Person>();
    }
}
