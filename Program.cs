using System;
using System.Collections.Generic;
using System.IO;
using Employee_Json.Models;
using Newtonsoft.Json;

namespace Employee_Json
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee
            {
                Id=1,
                Name="Ilkin",
                Surname="Ibrahimov",
                Age=21
            };
            Department department = new Department
            {
                Name="ILKIN",
                Employees=new List<Employee>
                { 
                    employee
                }
            };
            var serialize=JsonConvert.SerializeObject(employee);
            using (StreamWriter sr=new StreamWriter(@"C:\Users\tu7mrkt9v\Desktop\Employee_Json\Employee_Json\Data\json1.json"))
            {
                sr.WriteLine(serialize);
            }

            string result;
            using (StreamReader dr = new StreamReader(@"C:\Users\tu7mrkt9v\Desktop\Employee_Json\Employee_Json\Data\json1.json"))
            {
                result = dr.ReadToEnd();
            }
            var deserialize = JsonConvert.DeserializeObject(result);
            Console.WriteLine(deserialize);
        }
    }
}
