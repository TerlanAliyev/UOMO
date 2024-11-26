using System;
using System.Collections.Generic;

#nullable disable

namespace UOMO.Models
{
    public partial class Level
    {
        public Level()
        {
            Cargos = new HashSet<Cargo>();
        }

        public int LevelId { get; set; }
        public string LevelName { get; set; }

        public virtual ICollection<Cargo> Cargos { get; set; }
    }
}
