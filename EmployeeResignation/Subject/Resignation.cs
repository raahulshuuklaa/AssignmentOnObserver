using EmployeeResignation.Departments.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeResignation.Subject
{
    public class Resignation : IResignation
    {
        List<IResignationObserver> observerList;
        public Resignation()
        {
            observerList = new List<IResignationObserver>();
        }

        public void AddObserver(IResignationObserver observer)
        {
            observerList.Add(observer);
        }
        public void RemoveObserver(IResignationObserver observer)
        {
            observerList.Remove(observer);
        }

        public void NotifyObserver(string employeeId)
        {
            var distinctItems = observerList.Distinct();
            foreach (var observer in distinctItems)
            {
                observer.Notify(employeeId);
            }
        }

    }
}
