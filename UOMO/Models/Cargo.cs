using System;
using System.Collections.Generic;

#nullable disable

namespace UOMO.Models
{
    public partial class Cargo
    {
        public Cargo()
        {
            Boxes = new HashSet<Box>();
        }

        public int CargoId { get; set; }
        public DateTime? CargoDate { get; set; }
        public int? CargoTotalPrice { get; set; }
        public int? CargoLevelId { get; set; }
        public int? CargoUserId { get; set; }

        public virtual Level CargoLevel { get; set; }
        public virtual User CargoUser { get; set; }
        public virtual ICollection<Box> Boxes { get; set; }
    }
}
