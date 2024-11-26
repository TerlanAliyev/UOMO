using System;
using System.Collections.Generic;

#nullable disable

namespace UOMO.Models
{
    public partial class Shop
    {
        public int ShopId { get; set; }
        public string ShopName { get; set; }
        public string ShopEmail { get; set; }
        public string ShopPhone { get; set; }
        public string ShopPassword { get; set; }
        public string ShopProfilePhotoUrl { get; set; }
    }
}
