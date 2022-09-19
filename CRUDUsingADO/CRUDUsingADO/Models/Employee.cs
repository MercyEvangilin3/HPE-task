using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAnnotationsExtensions;
using System.ComponentModel.DataAnnotations;

namespace CRUDUsingADO.Models
{
    public class Employee
    {
        [Required]
        public int EId { get; set; }
        [Required]
        public string EmpName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int DId { get; set; }
        [Required]
        public string Gender { get; set; } 

    }
}