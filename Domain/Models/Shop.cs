using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Shop
    {

        [Key]
        public string? Id { get; set; }
        public string? Name { get; set; }
       
        public ShopCategory? ShopCategory { get; set; }
        public string? ShopCategoryId { get; set; }

       

    }
}
