using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuggedAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] arr = new int[2, 2, 3];

            for (int batch = 0; batch < 2; batch++)
            {
                for (int stud = 0; stud < 2; stud++)
                {
                    for (int marks = 0; marks < 3; marks++)
                    {
                        Console.WriteLine("Enter Batch no. {0}\nStudent No. {1}\nMarks = {2}",batch,stud,marks);
                        arr[batch, stud, marks] = Convert.ToInt32(Console.ReadLine());
                    
                    }
                      Console.WriteLine();
                }
            }


            for (int batch = 0; batch < 2; batch++)
            {
                for (int stud = 0; stud < 2; stud++)
                {
                    for (int marks = 0; marks < 3; marks++)
                    {
                        Console.WriteLine("Marks of Students present in each branch:-");
                        Console.WriteLine("Batch no.:- {0}, Student No.:- {1} , Marks = {2}", batch, stud, arr[batch,stud,marks]);

                        Console.ReadLine();
                    }

                }
            }

        }   
    }

   
}
