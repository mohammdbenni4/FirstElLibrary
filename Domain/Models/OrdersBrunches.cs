using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class OrdersBrunches
    {
        [Key]
        public string? Id { get; set; }
        public Brunch? Brunch { get; set; }
        public string? BrunchId { get; set; }
        public Order? Order { get; set; }
        public string? OrderId { get; set; }


    }
}
