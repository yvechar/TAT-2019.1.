

using System;

namespace task_22
{/// <summary>
///  Class Entry Point 
/// </summary>
    class EntryPoint
    {/// <summary>
     /// In the main we creat the object of class Phonema ,
     /// call the method CreatPhonema from the class Phonema ,
     /// write the phonema on console 
     /// </summary>
     /// <param name="args"> takes the string from the comman line</param>
        static void Main(string[] args)
        {
            try
            {

                foreach (var arg in args)
                {
                    Phonema Object = new Phonema(arg);
                    Console.WriteLine(Object.CreatPhonema(arg));
                    Console.WriteLine(arg);

                }
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Error: {e.Message}");
                //return 1;
            }

            catch (Exception)
            {
                Console.WriteLine("Error");
                //return 2;
            }
            Console.Read();
        }
    }
}