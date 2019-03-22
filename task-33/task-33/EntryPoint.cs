using System;
using System.Collections.Generic;


namespace task_33
{
    class EntryPoint
    {/// <summary>
     /// class EntryPoint here we choose the criteria and input fix money amount and productivity 
     /// Then throw all 
     /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args)
        {


            
            try
            {
                List<Employee> List = new List<Employee>();
                Company company = new Company();
                Console.Write("Select one of three selection criteria (Enter 1,2 or 3): ");
                Console.Write(" \n1.maximum productivity within the sum; \n2.minimum cost with fixed productivity ; \n3.minimum number of staff qualifications higher than junior for fixed productivity \n");
                string str = Console.ReadLine();
                int.TryParse(str, out int input_criteria);

                Console.Write(" Enter your money amount \n");
                string str1 = Console.ReadLine();
                int.TryParse(str1, out int input_money_amount);

                Console.Write(" Enter productivity \n");
                string str2 = Console.ReadLine();
                int.TryParse(str2, out int input_productivity);

                switch(input_criteria)
                {
                    case 1:
                        Optimazer obj1 = new FirstCriteria(input_money_amount);
                            List = company.GetEmployee(obj1);
                      //  List = company.EmployeeAndDisplay(obj1); 
                        break;

                    case 2:
                        Optimazer obj2 = new SecondCriteria(input_productivity);
                        List = company.GetEmployee(obj2);
                        break;

                    case 3:
                        Optimazer obj3 = new ThirdCriteria(input_productivity);
                        List = company.GetEmployee(obj3);
                        break;

                    default:
                        Console.WriteLine("Default case");
                        break;

                }
                company.EmployeeAndDisplay(List);
               
            }
            catch (Exception)
            { Console.WriteLine("Exception!"); }
            Console.Read();
        }
        
            
        }
    }

