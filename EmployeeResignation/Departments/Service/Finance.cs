using EmployeeResignation.Departments.Interface;
using EmployeeResignation.Subject;
using Observer.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeResignation.Departments.Service
{
    public class Finance : IFinance, IResignationObserver
    {
        public Finance(IResignation resignation)
        {
            resignation.AddObserver(this);
        }
        public void CalculateSalary()
        {
            // calculates salary
        }
        public void Notify(string employeeId)
        {
            UpdateXmlHelper xmlHelper = new UpdateXmlHelper();
            xmlHelper.UpdateNotificationDetail("Finance", employeeId);
        }
    }
}
