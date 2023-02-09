﻿namespace EmployeePayrollServiceSQL
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome To Employee Payroll Using Thread Problem");
            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();
            EmployeePayrollOperations employeePayrollOperations = new EmployeePayrollOperations();
            DateTime startDateTime = DateTime.Now;
            employeePayrollOperations.addEmployeeToPayroll(employeeDetails);
            DateTime stopDateTime = DateTime.Now;
            Console.WriteLine("Duration without thread: " + (stopDateTime - startDateTime));

            DateTime startDateTimeThread = DateTime.Now;
            employeePayrollOperations.addEmployeeToPayrollWithThread(employeeDetails);
            DateTime stopDateTimeThread = DateTime.Now;
            Console.WriteLine("Duration with Thread: " + (stopDateTimeThread - startDateTimeThread));




        }
    }
}