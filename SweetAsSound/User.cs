using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetAsSound
{
    internal class User
    {
        public User()

        { }
        public int UserID { get; set; }

        public string? FirstName { get; set; }  // Read-write property
        public string? LastName { get; set; }   // Read-write proper
        public string? Password { get; set; } // Read-write property
        public string? Email { get; set; } // Read-write property

    }
    }
