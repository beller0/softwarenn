using System;
using System.Collections.Generic;

namespace backendAg.Models
{
    public partial class Farmer
    {
        public Farmer()
        {
            Crops = new HashSet<Crop>();
        }

        public int IdFarmer { get; set; }
        public string FarmName { get; set; } = null!;
        public string CropsNumber { get; set; } = null!;

        public virtual User IdFarmerNavigation { get; set; } = null!;
        public virtual ICollection<Crop> Crops { get; set; }
    }
}
