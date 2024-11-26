using System;
using System.Collections.Generic;

#nullable disable

namespace UOMO.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int? OrderUserId { get; set; }
        public int? OrderBoxId { get; set; }
        public string OrderStatus { get; set; }
        public string OrderPrice { get; set; }

        public virtual Box OrderBox { get; set; }
        public virtual User OrderUser { get; set; }
    }
}
