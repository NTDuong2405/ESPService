using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WCFClient1.Models
{
    public class EmployeeViewModel
    {
        [ScaffoldColumn(false)]
        [Display(Name = "Ten Nhan Vien")]
        public string EmployeeName { get; set; }
        [Display(Name = "Phong ban")]
        public string Department { get; set; }
        [Display(Name = "Muc luong")]
        public double Salary { get; set; }
    }
}