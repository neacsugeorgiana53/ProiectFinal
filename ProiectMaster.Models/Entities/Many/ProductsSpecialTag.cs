﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ProiectEC.Entities
{
    public partial class ProductsSpecialTag
    {
        public int SpecialTagId { get; set; }
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
        public virtual SpecialTag SpecialTag { get; set; }
    }
}
