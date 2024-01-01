using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Address
    {
        public string? Id { get; set; }

        public string? Name { get; set; }

        public City? City { get; set; }
        public string? CityId { get; set; }

        public Neighborhood? Neighborhood { get; set; }
        public string? NeighborhoodId { get; set; }

        public string? Street { get; set; }
        public string? Building { get; set; }
        public string? Floor { get; set; }
        public string? MoreDetails { get; set; }

    }
}
