using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractEmployeeWage
{
    public class Employeecheck
    {
        public static void checkattendence ()
        {
            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HR = 20;

            int empHrs = 0;
            int empWage = 0;

            Random random= new Random();
            int empcheck =random.Next(0 , 3);
            switch (empcheck)
            {
                case IS_FULL_TIME:
                    Console.WriteLine("Employee is Present ");
                    empHrs = 8;
                    break;
                case IS_PART_TIME:
                    Console.WriteLine("Employee is Part Time");
                    empHrs = 4;
                    break;
                default:
                    Console.WriteLine("Eployee is Absent");
                    break;
            }
            empWage= EMP_RATE_PER_HR*empHrs;
            Console.WriteLine("EmpWage :" + empWage);
        }
        
    }
}
