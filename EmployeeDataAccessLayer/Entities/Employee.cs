﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeDataAccessLayer.Entities
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Address { get; set; }
        public string? City { get; set; }
        public decimal Salary { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set;}
        public int ModifiedBy { get; set;}
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
    }

}
