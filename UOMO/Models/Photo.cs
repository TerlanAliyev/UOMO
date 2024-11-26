using System;
using System.Collections.Generic;

#nullable disable

namespace UOMO.Models
{
    public partial class Photo
    {
        public int PhotoId { get; set; }
        public string PhotoUrl { get; set; }
        public int? PhotoProductId { get; set; }

        public virtual Product PhotoProduct { get; set; }
    }
}
