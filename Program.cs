using System;

namespace EmployeeObjectClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program on Master Branch");
            //UC1 Present = new UC1();
            //Present.PresentOrNot();

            //UC2 Daily = new UC2();
            //Daily.DailyWages();

            //UC3 Salary = new UC3();
            //Salary.PartTime();

            //UC4 Program = new UC4();
            //Program .SwitchCase();

            //UC5 Month = new UC5();
            //Month.MonthlySalary();

            //UC6 Wages = new UC6();
            //Wages.EmpDailyWage4();

            //UC_7_Refactor_The_Code.EmpWageUsingClassMethod();

            //UC8_EmpWageForMultipleCompanies.computeEmpWage("D-mart", 20, 10,10);
            //UC8_EmpWageForMultipleCompanies.computeEmpWage("Reliance", 10, 10, 10);

            //EmpWageBuildingObject dmart = new EmpWageBuildingObject("Dmart", 10, 1, 20);
            //EmpWageBuildingObject reliance = new EmpWageBuildingObject("Reliance", 12, 2, 20);
            //dmart.computeEmpWage();
            //Console.WriteLine(dmart.toString());
            //reliance.computeEmpWage();
            //Console.WriteLine(reliance.toString());


            //UC_10 uc10 = new UC_10();
            //uc10.addCompanyEmpWage("D-Mart", 10, 4, 20);
            //uc10.addCompanyEmpWage("Reliance", 20, 4, 20);
            //uc10.computeEmpWage();


            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmpWage("Dmart", 10, 2, 15);
            empWageBuilder.addCompanyEmpWage("Rel", 10, 2, 15);
            empWageBuilder.ComputeEmpWage();
            Console.WriteLine("Total Wage for Company dmart is : " + empWageBuilder.getTotalWage("Dmart"));




        }
    }
}
