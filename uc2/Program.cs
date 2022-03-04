using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uc2
{
    public class Uc_2_emp
    {

        //Constants
        public int is_Present = 1;
            public int emp_Rate_Per_Hr = 20;

            //variables
            public int empHrs = 0;
            public int empWage = 0;
        }
        public class Program
        {
            static void Main(string[] args)
            {
                Uc_2_emp uc2 = new Uc_2_emp();
                Random random = new Random();

                //Computation
                int empCheck = random.Next(0, 2);
                if (empCheck == uc2.is_Present)
                {
                    uc2.empHrs = 8;

                }
                else
                {
                    uc2.empHrs = 0;
                }
                uc2.empWage = uc2.empHrs * uc2.emp_Rate_Per_Hr;
                Console.WriteLine("Emp Wage =" + uc2.empWage);
            }
        }
    }
   