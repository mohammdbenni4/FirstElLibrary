using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Domain.Models
{
    public class Product
    {
        public string?  Id { get; set; }
        public string?  Name { get; set; }
        public int Price { get; set; }

        public Brunch? Brunch { get; set; }
        public string? BrunchId { get; set; }

        public int Calories { get; set; }
        public string? Description { get; set; }
        public bool IsAvailable { get; set; }

        public string? ProductImages { get; set; }

    }
}
