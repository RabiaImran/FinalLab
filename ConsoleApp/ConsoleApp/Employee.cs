using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    public interface Employee
    {
        int EmployeeID { get; set; }
        String EmployeeName { get; set; }
        string EmployeeType { get; set; }
        int NoHoursWork { get; set; }
        int NoOfUnit { get; set; }
        Hourly_Employee Hourly_Employee { get; set; }
    }
}