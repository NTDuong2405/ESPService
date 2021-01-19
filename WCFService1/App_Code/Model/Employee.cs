using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for Employee
/// </summary>
[DataContract]
public class Employee
{
    [DataMember] public int EmployeeId { get; set; }
    [DataMember] public string EmployeeName { get; set; }
    [DataMember] public string Department { get; set; }
    [DataMember] public double Salary { get; set; }
   
}