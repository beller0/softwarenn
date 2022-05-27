using System;
using System.Collections.Generic;

namespace backendAg.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Email { get; set; }
        public string Password { get; set; } = null!;
        public string sal { get; set; }

        public virtual Administrator Administrator { get; set; } = null!;
        public virtual Farmer Farmer { get; set; } = null!;
    }
}
