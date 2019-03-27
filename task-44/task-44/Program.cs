using System;

namespace task_44
{
/// <summary>
/// the main
/// </summary>
    class EntryPoint
    {/// <summary>
     /// the entry point to the program
     /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                Discipline Math = new Discipline();
                Discipline Phusics = new Discipline();
                Seminar English = new Seminar();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error!: {ex.Message}");
            }
        }
    }
}
