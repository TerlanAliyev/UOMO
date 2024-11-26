using System;
using System.Collections.Generic;

#nullable disable

namespace UOMO.Models
{
    public partial class Size
    {
        public Size()
        {
            Baskets = new HashSet<Basket>();
            Products = new HashSet<Product>();
        }

        public int SizeId { get; set; }
        public string SizeName { get; set; }

        public virtual ICollection<Basket> Baskets { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
