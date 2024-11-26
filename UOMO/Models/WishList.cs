using System;
using System.Collections.Generic;

#nullable disable

namespace UOMO.Models
{
    public partial class WishList
    {
        public int WishId { get; set; }
        public int? WishProductId { get; set; }
        public int? WishUserId { get; set; }

        public virtual Product WishProduct { get; set; }
        public virtual User WishUser { get; set; }
    }
}
