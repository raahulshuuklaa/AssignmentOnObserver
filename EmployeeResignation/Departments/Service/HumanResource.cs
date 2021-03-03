using EmployeeResignation.Departments.Interface;
using EmployeeResignation.Subject;
using Observer.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeResignation.Departments.Service
{
    public class HumanResource : IHumanResource, IResignationObserver
    {

        public HumanResource(IResignation resignation)
        {
            resignation.AddObserver(this);
        }


        public void HandOverAssets()
        {
            //throw new NotImplementedException();
        }

        public void Notify(string employeeId)
        {
            UpdateXmlHelper xmlHelper = new UpdateXmlHelper();
            xmlHelper.UpdateNotificationDetail("HR", employeeId);
        }
    }
}