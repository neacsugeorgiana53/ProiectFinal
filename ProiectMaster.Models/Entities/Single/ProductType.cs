﻿using ProiectMaster.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace ProiectEC.Entities
{
    public partial class ProductType : IEntity<int>
    {
        public ProductType()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
