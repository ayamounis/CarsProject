﻿using System.ComponentModel.DataAnnotations;

namespace CarsProject.Models
{
    public class RoleViewModel
    {
        [Display(Name ="Role Name")]
        public string RoleName { get; set; }
    }
}
