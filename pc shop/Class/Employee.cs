using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pc_shop.Class
{
    public abstract class Employee
    {
      
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        protected string position = "Unknown";
        public abstract string Position { get; }
        public int phone { get; set; }
        public byte[] img { get; set; }
        public abstract void AddEmployee(Employee employee);
        public abstract void RemoveEmployee(Employee employee);

        public abstract void UpdateEmployee(Employee employee);
        public abstract Employee GetEmployee(int id);
        public abstract List<Employee> GetEmployees();
        public abstract void ClearEmployee();
        public abstract int GetEmployeeCount();
        
        public Employee()
        {
        }

        public Employee(string Id, string Name, string Email, string Password, int phone, byte[] img)
        {
            this.Id = Id;
            this.Name = Name;
            this.Email = Email; 
            this.Password = Password;
            this.phone = phone;
            this.img = img;

        }

    }
}
