using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Core.Entities
{
    public class CinemaHall : BaseEntity
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
