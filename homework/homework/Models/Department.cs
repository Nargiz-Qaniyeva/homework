using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace homework.Models
{
    internal class Department
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        private List<Employee> _employees;
        public void AddEmployee()
        {
            Employee employee = new Employee(); 
        }
        public void Work(int id)
        {
            id++;
            foreach (object item in _employees)
            {
                if (item == null) continue;
                foreach (PropertyInfo property in item.GetType().GetProperties())
                {
                    Console.WriteLine(item);
                }
            }

        }


    }   
}
