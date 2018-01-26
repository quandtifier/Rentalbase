﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rentalbase.Models
{
    public class Landlord
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Property> Properties { get; set; }
    }
}