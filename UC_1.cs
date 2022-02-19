using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_By_OOPS
{
    
        class UC1
        {
            public void PresentOrNot()
            {
                Random random = new Random();
                int number = random.Next(0,2);
                {
                    if (number == 0)
                    {
                        Console.WriteLine("Empl is Present");
                    }
                    else
                    {
                        Console.WriteLine("Empl is Absent");
                    }

                }
            }
        }
}