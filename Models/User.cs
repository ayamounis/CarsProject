﻿
using Microsoft.AspNetCore.Identity;
namespace CarsProject.Models
{
    public class User:IdentityUser
    {
        //public int Id { get; set; }
        //public string UserName { get; set; }
        //public string Password { get; set; }
        //public string Email { get; set; }
        //public string Role { get; set; } // Admin / Customer

        public List<Order>? Orders { get; set; }
        public List<Review>? Reviews { get; set; }
    }
}
