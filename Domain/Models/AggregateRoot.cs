﻿using Elkood.Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class AggregateRoot : AggregateRoot<Guid>
    {
        protected AggregateRoot()
        {
            Id = Guid.NewGuid();
        }
    }
}
