using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Observer.Departments
{
    public class UpdateXmlHelper
    {
        public async Task UpdateNotificationDetail(string department, string employeeId)
        {
           
            XDocument xDocument = XDocument.Load("wwwroot/NotifiedDepartment.xml");
            XElement dept = xDocument.Element("Department");
            XElement elementFinance = dept.Element(department);
            if (elementFinance == null)
            {
                dept.Add(new XElement(department,
                           new XElement("EmployeeId", employeeId)));
            }
            else
            {
                elementFinance.Add(new XElement("EmployeeId", employeeId));
            }
            xDocument.Save("wwwroot/NotifiedDepartment.xml");
        }
    }
}
