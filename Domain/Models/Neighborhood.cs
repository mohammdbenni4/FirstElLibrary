﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Neighborhood
    {
        [Key]
        public string? Id { get; set; }
        public string? Name { get; set; }
    }
}
