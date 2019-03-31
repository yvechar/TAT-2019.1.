namespace task_5
{
    /// <summary>
    /// Struct Point which incapsulates three coordinates 
    /// </summary>
     public struct Point
    {
        public int x { get; }
        public int y { get; }
        public int z { get; }

        /// <summary>
        /// The constructor of Struct Point
        /// </summary>
        /// <param name="x">coordinate x</param>
        /// <param name="y">coordinate y</param>
        /// <param name="z">coordinate z</param>
        public Point (int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}