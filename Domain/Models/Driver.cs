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
    public class Driver
    {
        [Key]
        public string? Id { get; set; }
        public string? Name { get; set; }

        public City? City { get; set; }
        public string? CityId { get; set; }

        public string? Email { get; set; }
        public string? MobileNumber { get; set; }
        public string? TelegramId { get; set; }
        public DateOnly? BornDate { get; set; }

        public string? Address { get; set; }

        public bool ProfitIsPercentage{ get; set; }

        public int ProfitAmount { get; set; }
        [NotMapped]
        public WorkTimeValueObject? WorkTimes { get; set; }

    }
}
