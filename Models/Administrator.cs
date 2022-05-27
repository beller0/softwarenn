using System;
using System.Collections.Generic;

namespace backendAg.Models
{
    public partial class Administrator
    {
        public Administrator()
        {
            Articles = new HashSet<Article>();
        }

        public int SpecialId { get; set; }

        public virtual User Special { get; set; } = null!;
        public virtual ICollection<Article> Articles { get; set; }
    }
}
