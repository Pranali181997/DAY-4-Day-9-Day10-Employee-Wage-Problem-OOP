using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_By_OOPS
{
    class UC_4
    {
        //constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public static void EmpWageUsingSwitch()
        {

            //variable
            int emp_wage = 0;
            int emp_Hrs = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 3);

            switch(empCheck)
            {
                case IS_FULL_TIME:
                emp_Hrs = 8;
                    break;
                case IS_PART_TIME:
                    emp_Hrs = 4;
                    break;
                default:
                    emp_Hrs = 0;
                    break;
            }

                    emp_wage = emp_Hrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee wages are " + emp_wage);

        }

    }
}


