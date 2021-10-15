using ProiectMaster.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace ProiectEC.Entities
{
    public partial class SpecialTag : IEntity<int>
    {
        public SpecialTag()
        {
            ProductsSpecialTags = new HashSet<ProductsSpecialTag>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ProductsSpecialTag> ProductsSpecialTags { get; set; }
    }
}
