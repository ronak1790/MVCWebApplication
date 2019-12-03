using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models {

    [Table("Employees")]
    public class Employee {
        public int EmployeeID { get; set; }
        [Required]
        [Display(Name="First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name="Last Name")]
        public string LastName { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public DateTime HireDate { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string HomePhone { get; set; }
        public string Extension { get; set; }
     
        public string Notes { get; set; }

        public int DepartmentID { get; set; }
     
     
    }

}