using System.Collections.Generic;
using System;
namespace task_33
{
    public class Company
    {


        public Company() { }
        public List<Employee> GetEmployee(Optimazer optimazer)
        {
            return optimazer.Choose();
        }


        public void EmployeeAndDisplay(List<Employee> List)
        {
            int[] employeesAmount = new int[4];
            foreach (Employee employee in List)
            {
                if (employee is Junior)
                {
                    employeesAmount[0]++;
                    continue;
                }
                if (employee is Lead)
                {
                    employeesAmount[3]++;
                    continue;
                }
                if (employee is Senior)
                {
                    employeesAmount[2]++;
                    continue;
                }
                if (employee is Middle)
                {
                    employeesAmount[1]++;
                    continue;
                }

            }
            Console.WriteLine("The number of employees you need:");
            Console.WriteLine($"Junior: {employeesAmount[0]}\nMiddle: {employeesAmount[1]}\nSenior: {employeesAmount[2]}\nLead:   {employeesAmount[3]}"); }
        

    }

}
 
        
    
