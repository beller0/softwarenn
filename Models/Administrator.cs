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

        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;

        public virtual ICollection<Article> Articles { get; set; }
    }
}
