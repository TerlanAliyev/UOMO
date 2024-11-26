using System;
using System.Collections.Generic;

#nullable disable

namespace UOMO.Models
{
    public partial class Box
    {
        public Box()
        {
            Orders = new HashSet<Order>();
        }

        public int BoxId { get; set; }
        public int? BoxCargoId { get; set; }
        public int? BoxUserId { get; set; }
        public string BoxSize { get; set; }
        public string BoxColor { get; set; }
        public int? BoxProductId { get; set; }
        public int? BoxCount { get; set; }
        public int? BoxTotalPrice { get; set; }

        public virtual Cargo BoxCargo { get; set; }
        public virtual Product BoxProduct { get; set; }
        public virtual User BoxUser { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
