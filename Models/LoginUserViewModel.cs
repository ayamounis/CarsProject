﻿using System.ComponentModel.DataAnnotations;

namespace CarsProject.Models
{
    public class LoginUserViewModel
    {
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string password { get; set; }
        public bool RememberMe { get; set; }


    }
}
