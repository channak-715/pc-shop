using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pc_shop.Class
{
    public class Manager:Employee
    {
        private List<Employee> employees = new List<Employee>();

        public override string Position => base.position;

        public Manager()
        {
            base.position = "Manager";
        }

        public Manager(string Id, string Name, string Email, string Password, int phone, byte[] img)
            : base(Id, Name, Email, Password, phone, img)
        {
            base.position = "Manager";
        }

        public override void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public override void ClearEmployee()
        {
            employees.Clear();
        }

        public override Employee GetEmployee(int id)
        {
            return employees[id];
        }

        public override int GetEmployeeCount()
        {
            return employees.Count();
        }

        public override List<Employee> GetEmployees()
        {
            return employees;
        }

        public override void RemoveEmployee(Employee employee)
        {
            employees.Remove(employee);
        }

        public override void UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}


