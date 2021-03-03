using EmployeeResignation.Departments.Interface;
using EmployeeResignation.Departments.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeResignation.Subject
{
    public interface IResignation
    {
        void AddObserver(IResignationObserver observer);
        void RemoveObserver(IResignationObserver observer);
        void NotifyObserver(string employeeId);
    }
}
