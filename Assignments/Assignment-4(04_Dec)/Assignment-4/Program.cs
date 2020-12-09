using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        static void Main()
        {
            Employee[] arr = new Employee[3];

            //reading from user
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter Employee Name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter Dept No.:");
                int dept =Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Address");
                string add = Console.ReadLine();

                Console.WriteLine("Enter Salary:");
                decimal sal = decimal.Parse(Console.ReadLine());

                arr[i] = new Employee(name, dept, add, sal);

                Console.ReadLine();
            }

            foreach (Employee e in arr)
            {
                Console.WriteLine("\n");
                e.EmpDetails();
                
            }

            decimal temp = arr[0].EMPSALARY;
            int tempId = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].EMPSALARY > temp)
                {
                    temp = arr[i].EMPSALARY;
                    tempId = arr[i].EMPID;
                }
            }

            for(int i = 0; i<arr.Length; i++)
            {
                if (arr[i].EMPID == tempId)
                {
                    Console.WriteLine("\nEmployee with highest salary:-");
                    arr[i].EmpDetails();
                    Console.ReadLine();
                }
               
            }

            Console.WriteLine("\n Enter the Id of Employee!");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].EMPID == id)
                {
                    arr[i].EmpDetails();
                    break;
                }        
            }

            foreach (Employee e in arr)
            {
                if (e.EMPID == id)
                {
                    e.EmpDetails();
                    Console.ReadLine();
                } 
                    
                
            }
        }
    }

    class Employee
    {
        private int empId;
        private string empName;
        private int deptNo;
        private string empAdd;
        private decimal empSalary;
        private static int count;

        public Employee(string empName, int deptNo, string empAdd, decimal empSalary)
        {
            this.EMPNAME = empName;
            this.DEPTNO = deptNo;
            this.EMPADD = empAdd;
            this.EMPSALARY = empSalary;
            empId = ++count;

        }

        public int EMPID
        {
            get
            {
                return empId;
            }
        }

        public string EMPNAME
        { 
            set
            {
                empName = value;
            }
            get
            {
                return empName;
            }
        }

        public int DEPTNO
        {
            set 
            {
                deptNo = value;    
            }
            get
            {
                return deptNo;
            }
        }

        public string EMPADD
        {
            set
            {
                empAdd = value;
            }
            get
            {
                return empAdd;
            }
        
        }

        public decimal EMPSALARY
        {
            set
            {
                empSalary = value;
            }
            get
            {
                return empSalary;
            }
        }

        public void EmpDetails()
        {
            Console.WriteLine("Id: "+ empId + "\nName: " + empName + "\nDept No: " + deptNo + "\nAddr: " + empAdd + "\nSalary: " + empSalary);
        }

    }
}
