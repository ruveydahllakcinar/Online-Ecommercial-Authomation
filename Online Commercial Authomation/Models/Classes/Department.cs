﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Online_Commercial_Authomation.Models.Classes
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Display(Name = "Department Name")]
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string DepartmentName { get; set; }
        public bool Situation { get; set; }
        public ICollection<Employee> Employees { get; set; }

    }

}