using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Core.Entities
{
    public class Movie : BaseEntity 
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Genre Genre { get; set; }
        public string Picture { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Actor { get; set; }
        public string Term { get; set; }
        public CinemaHall Hall { get; set; }
        public double TotalRating { get; set; }
        public int TimesRated { get; set; }
    }
}
