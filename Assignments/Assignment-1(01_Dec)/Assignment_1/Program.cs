using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Sandy", 123456, 10);
            Console.WriteLine("Employee Number:" + Employee.EMPNO + " Employee Name: " + emp.NAME + " Basic Salary: " + emp.BASIC + "Department No: " + emp.DEPTNO + "Employee Net Salary: " +emp.GetNetSalary() );

            Employee emp1 = new Employee("Sidd", 123456);
            Console.WriteLine("Employee Number:" + Employee.EMPNO + " Employee Name: " + emp1.NAME + " Basic salary: " + emp1.BASIC + " Employee net salary: " + emp1.GetNetSalary());


            Employee emp2 = new Employee("San");
            Console.WriteLine("Employee Number:" + Employee.EMPNO + " Employee Name: " + emp2.NAME);

            Console.ReadLine();
        }
    }

    class Employee
    {   
        //Constructor
        public Employee(string name,decimal basic,short deptNo )
        {
            this.NAME = name;
            empNo++;
            this.BASIC = basic;
            this.DEPTNO = deptNo;
        }

        public Employee(string name, decimal basic)
        {
            this.NAME = name;
            empNo++;
            this.BASIC = basic;
        }

        public Employee(string name)
        {
            this.NAME = name;
            empNo++;
        }

        private string name;
        private static int empNo;
        private decimal basic;
        private short deptNo;
        public string NAME
        {
            set
            {
                if (value != " ")
                    name = value;
                else
                    Console.WriteLine("Name Cannot be Blank!");
            }

            get
            {
                return name;
            }
        }

        public static int EMPNO
        {
            get
            {
                return empNo;
            }
        }

        public decimal BASIC
        {
            set
            {
                if (value >= 100000 && value <= 1000000)
                    basic = value;
                else
                    Console.WriteLine("out of range");
            }

            get
            {
                return basic;
            }
        }

        public short DEPTNO
        {
            set
            {
                if (value > 0)
                    deptNo = value;
                else
                    Console.WriteLine("Department number must be greater than Zero");
            }
            get
            {
                return deptNo;
            }
        }

        //METHODS

        public decimal GetNetSalary()
        { 
            return 12*basic;        
        }

        
    }
}
