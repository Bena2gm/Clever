using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleverServer.Models
{
    public class User : IdentityUser
    {
        public int Coin { get; set; }
        public int Point { get; set; }

    }
}
