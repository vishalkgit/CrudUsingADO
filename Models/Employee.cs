﻿using System.ComponentModel.DataAnnotations;

namespace CrudUsingADO.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }

        [Required]
        [Display(Name="Employee Name")]

        public string? Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email ID")]
        public string? Email { get; set; }

        [Display(Name = "Employee Salary")]
        [Required]
        public double Salary { get; set; }
    }
}
