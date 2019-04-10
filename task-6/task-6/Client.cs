using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace task_6
{
    /// <summary>
    /// 
    /// </summary>
    class Client
    {
        XmlDocument xDoc;
        string inputcommand=null;
      
        /// <summary>
        /// The constructor of  class
        /// </summary>
        /// <param name="file_name">name of xml file</param>
        public Client(string file_name)
        {
            xDoc = new XmlDocument();
            xDoc.Load(file_name);
            
        }

        /// <summary>
        /// The method that calls commands
        /// </summary>
        /// <param name="file_name">name of xml file</param>
        public void CalledCommands(string file_name)
        {
            AllCommandClass command = new AllCommandClass(@"D:\tasks\task-6\task-6\" + file_name);
            while (true)
            {
                Console.WriteLine("Enter Command:/n" +
                    " 1.brand(to get number of car brands);/n" +
                    " 2.count(to get total number of cars);/n" +
                    " 3.aprice (to get average cost of a car);/n"+
                    " 4.apricetype (to get average cost of a car one type);/n"+
                    " 5.exit(exit from programm)."
                    );

                if(inputcommand == "brand")
                {
                    command.Get_Types();
                }

                if (inputcommand == "count")
                {
                    command.Get_Count();
                }

                if (inputcommand == "aprice")
                {
                    command.Get_AveragePrice();
                }

                if (inputcommand == "apricetype")
                {
                    command.Get_AveragePriceType();
                }

                if (inputcommand == "exit")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Please, Enter correct command.");
                }
            }
        }
    }
}
