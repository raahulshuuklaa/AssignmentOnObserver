using EmployeeResignation.Departments.Interface;
using EmployeeResignation.Subject;
using Observer.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeResignation.Departments.Service
{
    public class IT : IAsset, IResignationObserver
    {
        public IT(IResignation resignation)
        {
            resignation.AddObserver(this);
        }
        public void AllocateAsset()
        {
            // Allocate asset
        }
        public void Notify(string employeeId)
        {
            // whenever employee resigns notification will come here.
            // Finance department will take necessary action accordingly.

            UpdateXmlHelper xmlHelper = new UpdateXmlHelper();
            xmlHelper.UpdateNotificationDetail("IT", employeeId);
        }
    }

}
