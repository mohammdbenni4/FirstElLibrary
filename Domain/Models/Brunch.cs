using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Brunch
    {
        [Key]
        public string? Id { get; set; }
        public string? Name { get; set; }

        public bool IsMainBrunch { get; set; }
        public City? City { get; set; }
        public string? CityId { get; set; }
        public string? MobileNumber { get; set; }
        public string? Address { get; set; }
        public Shop? Shop { get; set; }
        public string? ShopId { get; set; }

        public bool  PaymentImmediatly { get; set; }
        public bool  DisplayThisBrunch { get; set; }

        public string? ImageUrls { get; set; }  

       
        public List<ProductCategory>? productCategories { get; set; }
        

        public List<Product>? Products { get; set; }
        [NotMapped]
        public WorkTimeValueObject? WorkTimes { get; set; }
    }
}
