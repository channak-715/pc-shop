using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pc_shop.Class
{
    public class staff:Employee
    {
        public override string Position => base.position;
        public staff()
        {
            base.position = "staff";
        }
        public staff(string Id, string Name, string Email, string Password, int phone, byte[] img)
            : base(Id, Name, Email, Password, phone, img)
        {
            base.position = "staff";
        }

        public staff(TextBox txtID, TextBox txtname, TextBox txtemail, TextBox txtpass, TextBox txtphone, byte[] bytes)
        {
        }

        public override void AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public override void RemoveEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public override void UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public override Employee GetEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Employee> GetEmployees()
        {
            throw new NotImplementedException();
        }

        public override void ClearEmployee()
        {
            throw new NotImplementedException();
        }

        public override int GetEmployeeCount()
        {
            throw new NotImplementedException();
        }
    }
}
