using System;
using System.Collections.Generic;

#nullable disable

namespace UOMO.Models
{
    public partial class Basket
    {
        public int BasketId { get; set; }
        public int? BasketProductId { get; set; }
        public int? BasketUserId { get; set; }
        public int? BasketColorId { get; set; }
        public int? BasketSizeId { get; set; }
        public int? BasketTotalPrice { get; set; }
        public int? BasketCount { get; set; }

        public virtual Color BasketColor { get; set; }
        public virtual Product BasketProduct { get; set; }
        public virtual Size BasketSize { get; set; }
        public virtual User BasketUser { get; set; }
    }
}
