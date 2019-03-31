using System;
using System.Collections.Generic;

namespace task_5
{
    /// <summary>
    /// The Entry Point to the progaram, provides the main method 
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// In the main we creat the objects of classes , add them to the list  and сall some methods
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                Point FinalPoint = new Point(100, 200, 800);
                Bird obj1 = new Bird();
                Plane obj2 = new Plane();
                SpaceShip obj3 = new SpaceShip();
                List<IFlyable> FlyingObjects = new List<IFlyable>() { obj1, obj2, obj3 };
                foreach (var i in FlyingObjects)
                {
                    i.FlyTo(FinalPoint);
                }
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}
