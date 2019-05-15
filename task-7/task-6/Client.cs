using System;
using System.Xml;

namespace task_6
{
    /// <summary>
    /// Thhe class Client that works with commands thit input
    /// </summary>
    class Client
    {
        XmlDocument xDoc;
        public Car Car { get; set; }
        public Truck Truck { get; set; }
           
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
        public void CalledCommands(string file_name1,string file_name2)
        {
            SetCommand invoker = new SetCommand();
            Car = Car.getInstance(@"D:\tasks\task-6\task-6\" + file_name1);
            Truck = Truck.getInstance(@"D:\tasks\task-6\task-6\" + file_name2);
            Console.WriteLine("Enter Command:/n" +
                " 1.brand(to get number of car brands);/n" +
                " 2.count(to get total number of cars);/n" +
                " 3.aprice (to get average cost of a car);/n" +
                " 4.apricetype (to get average cost of a car one type);/n" +
                " 5.exit(exit from programm)."
                );
                string inputcommand=Console.ReadLine();
                if (inputcommand == "brand")
                {
                    invoker.Command(new CommandTypes(Car));
                    invoker.GetCommand();
                    invoker.Command(new CommandTypes(Truck));
                    invoker.GetCommand();
                }

                if (inputcommand == "count")
                {
                    invoker.Command(new CommandCount(Car));
                    invoker.GetCommand();
                    invoker.Command(new CommandTypes(Truck));
                    invoker.GetCommand();
                }

                if (inputcommand == "aprice")
                {
                    invoker.Command(new CommandAveragePrice(Car));
                    invoker.GetCommand();
                    invoker.Command(new CommandTypes(Truck));
                    invoker.GetCommand();
                }

                if (inputcommand == "apricetype")
                {
                    invoker.Command(new CommandAveragePriceType(Car));
                    invoker.GetCommand(); ;
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
