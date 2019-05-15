namespace task_6
{
    /// <summary>
    /// The class use  Singleton pattern to creat only one object 
    /// </summary>
    class Car : Transport
    {
        private static Car instance;

        private Car(string filename)  :base (filename)
        { }

        public static Car getInstance(string filename)
        {
            if (instance == null)
            instance = new Car(filename);
            return instance;
        }
    }
}
