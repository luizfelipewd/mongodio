using System;

namespace mongodio.Models
{
    public class InfectedDto
    {
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}