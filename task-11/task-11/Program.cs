using System;

namespace Task_1
{
    /// <summary>
    /// The Class EntryPoint provides main
    /// </summary>
    /// <param name="args">arguments from command line</param>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                foreach (string arg in args)
                {
                    SearchForConSymbols Obj = new SearchForConSymbols();
                    Obj.SearchAndDisplay(arg);
                }
            }
            catch (FormatException)

            {
                Console.WriteLine("Empty String");
            }

            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }
    }
}
