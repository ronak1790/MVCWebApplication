using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models {
    
    public class Department {
        public int Id { get; set; }

        [Required]
        [Display(Name="Department Name")]
        public string Name { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
