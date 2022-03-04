using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uc1
{
    public class UC_1_Emp
    {
        //Constants
        public int Is_Full_Time = 1;


    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            //Computation
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            UC_1_Emp emp = new UC_1_Emp();


            if (empcheck == emp.Is_Full_Time)
            {
                Console.WriteLine("employee is Present");
            }
            else
            {
                Console.WriteLine("employee is Absent");
            }
        }
    }
}

