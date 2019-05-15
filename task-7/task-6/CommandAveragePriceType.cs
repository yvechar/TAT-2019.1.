using System;

namespace task_6
{
    /// <summary>
    /// The class CommandAveragePriceType
    /// </summary>
    class CommandAveragePriceType : ICommand
    {
        public string type;
        Transport types;

        public CommandAveragePriceType(Transport types)
        {
            this.types = types;
        }

        public void Execute()
        {
            Console.WriteLine("Enter type :");
            Console.ReadLine();
            types.Get_AveragePriceType(type);
        }
    }
}
