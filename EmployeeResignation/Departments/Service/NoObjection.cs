using EmployeeResignation.Departments.Interface;
using EmployeeResignation.Subject;
using Observer.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeResignation.Departments.Service
{
    public class NoObjection : IAccount, IResignationObserver
    {
        public NoObjection(IResignation resignation)
        {
            resignation.AddObserver(this);
        }
        public void GiveNoObjection()
        {
            //throw new NotImplementedException();
        }
        public void Notify(string employeeId)
        {
            // whenever employee resigns notification will come here.
            // Account department will take necessary action accordingly.

            UpdateXmlHelper xmlHelper = new UpdateXmlHelper();
            xmlHelper.UpdateNotificationDetail("Account", employeeId);
        }
    }
}
