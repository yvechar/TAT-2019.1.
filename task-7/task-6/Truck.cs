namespace task_6
{
    /// <summary>
    /// The class use  Singleton pattern to creat only one object 
    /// </summary>
    class Truck : Transport
    {
        private static Truck instance;

        private Truck(string filename) :base(filename)
        { }

        public static Truck getInstance(string filename)
        {
            if (instance == null)
            instance = new Truck(filename);
            return instance;
        }
    }
}
