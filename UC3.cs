using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_By_OOPS
{
    public class UC3
    {
        public static void Part_Time_Emp1()
        {
            //constants
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;

            //variable
            int emp_wage = 0;
            int emp_Hrs = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 3);
            
            if(empCheck == IS_FULL_TIME)
            {
                emp_Hrs = 8;
            }
            else if (empCheck == IS_PART_TIME)
            {
                emp_Hrs = 4;
            }
            else
            {
                emp_Hrs = 0;
            }
            emp_wage = emp_Hrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee wages are " + emp_wage);

        }

    }
}
