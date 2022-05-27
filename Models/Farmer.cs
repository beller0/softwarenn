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

        public int Id { get; set; }
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;

        public virtual ICollection<Crop> Crops { get; set; }
    }
}
