using System;
using System.Collections.Generic;

#nullable disable

namespace UOMO.Models
{
    public partial class Color
    {
        public Color()
        {
            Baskets = new HashSet<Basket>();
            Products = new HashSet<Product>();
        }

        public int ColorId { get; set; }
        public string ColorName { get; set; }

        public virtual ICollection<Basket> Baskets { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
