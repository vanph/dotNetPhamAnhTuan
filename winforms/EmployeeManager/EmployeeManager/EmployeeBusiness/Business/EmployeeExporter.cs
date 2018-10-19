using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmployeeBusiness.Models;
using System.IO;
using EmployeeBusiness.Helpers;

namespace EmployeeBusiness.Business
{
   public class EmployeeExporter
    {
        public void Export(List<Employee> employees, string fileName)
        {
            var employeeStringBuilder = new StringBuilder();
            var index = 0;
            foreach (var emp in employees)
            {
                index++;
                employeeStringBuilder.Append($"{index}. FullName: {emp.FirstName} {emp.LastName} - Address: {emp.Address} - Age: {emp.Age} - Gender: {emp.Gender} {Environment.NewLine}");
            }

            FileHelpers.WriteFile(employeeStringBuilder.ToString(), fileName);
        }

        public void ExportCsv(List<Employee> employees, string fileName, string separatorCharacter)
        {
            var employeeStringBuilder = new StringBuilder();
            
            foreach (var emp in employees)
            {
                employeeStringBuilder.Append($"{emp.FirstName}{separatorCharacter}{emp.LastName}{Environment.NewLine}");
            }

            FileHelpers.WriteFile(employeeStringBuilder.ToString(), fileName);
        }
    }
}
