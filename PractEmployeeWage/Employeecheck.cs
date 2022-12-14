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
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HR = 20;

            int empHrs = 0;
            int empWage = 0;

            Random random= new Random();
            int empcheck =random.Next(0 , 3);

            if(empcheck == IS_FULL_TIME )
            {
                Console.WriteLine("Employee is Present ");
                empHrs = 8;
            }
            else if(empcheck ==IS_PART_TIME)
            {
                Console.WriteLine("Employee is Part Time");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Eployee is Absent");
            }
         empWage= EMP_RATE_PER_HR*empHrs;
            Console.WriteLine("EmpWage :" + empWage);
        }
        
    }
}
