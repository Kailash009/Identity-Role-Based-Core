﻿using Microsoft.AspNetCore.Identity;

namespace RoleIdentity.Models
{
    public class ApplicationUser: IdentityUser  // Add Custom Property in AspNetUsers Table Identity.....
    {
        // Add Your Custom Property....
        public string FirstName { get; set; }
        
        // Add Your Custom Property....
        public string LastName { get; set; }

        // Add Your Custom Property....
        public int Age { get; set; }

        // Add Your Custom Property....
        public string MobileNo { get; set; }

        // Add Your Custom Property....
        public double Salary { get; set; }
    }
}
