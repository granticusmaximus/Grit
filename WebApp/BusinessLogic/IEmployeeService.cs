﻿using System;
using System.Collections.Generic;
using WebApp.Models;

namespace WebApp.BusinessLogic
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> Employee();
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployeeById(int EmpID);
        bool CreateEmployee(Employee employee);
        bool UpdateEmployee(Employee employee);
        bool DeleteEmployee(Employee employee);
        bool ValidateEmp(Employee employee);
    }
}