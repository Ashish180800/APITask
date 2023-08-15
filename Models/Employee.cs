using System;
using System.Collections.Generic;

namespace APITask.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string EmployeeName { get; set; } = null!;

    public DateTime EmployeeDob { get; set; }

    public string Gender { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string State { get; set; } = null!;
}
