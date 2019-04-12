using System;
using System.Xml;

namespace task_6
{
    /// <summary>
    /// The class Entry Point provides the method main
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// The method Main , here we get the name of xml file and give to the class Client
        /// </summary>
        /// <param name="args">argument from the command line (name of the xml file)</param>
        static void Main(string[] args)
        {
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(args[0]); 
                Client client = new Client(args[0]);
                client.CalledCommands(args[0]);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error! {ex.Message}");
            }
            Console.Read();
        }
    }
}
