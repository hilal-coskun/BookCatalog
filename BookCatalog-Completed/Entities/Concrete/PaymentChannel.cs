﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class PaymentChannel : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public List<Order> Order { get; set; }
    }
}
