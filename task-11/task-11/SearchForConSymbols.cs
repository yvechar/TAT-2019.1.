using System;



namespace Task_1
{
    /// <summary>
    /// Class  SearchAndDisplay is searching repeating symbols and than display them
    /// It also checks the input string and if it has less than 2 symbols throws the exception
    /// </summary>
    internal class SearchForConSymbols
    {
        public String NewLine;
        public SearchForConSymbols() { }
        /// <summary>
        /// The Constructor that checks input string
        /// </summary>
        public SearchForConSymbols(string arg)
        {

            if (arg.Length < 2)
            {
                throw new FormatException();
            }
            else
            {
                NewLine = arg;
            }
        }

        /// <summary>
        /// The method that finds and display the same symbols in the string
        /// </summary>
        public void SearchAndDisplay(string args)
        {
            NewLine = null;
            for (int i = 0; i < args.Length; i++)
            {
                NewLine = String.Empty;
                NewLine += args[i];
                for (int j = 0; j < args.Length - i - 1; j++)
                {
                    NewLine += args[i + 1 + j];
                    if (args[i + j] != args[i + 1 + j])
                    {
                        Console.WriteLine(NewLine);
                    }
                    else break;
                }
            }

        }
    }
}