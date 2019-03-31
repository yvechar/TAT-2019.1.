using System;

namespace task_5
{
    /// <summary>
    /// The class Bird that implements IFlyable interface and is child of  class  FlyingObject 
    /// </summary>
    public class Bird : FlyingObject, IFlyable
    {
        Random random = new Random();

        /// <summary>
        /// The contructor of class
        /// </summary>
        public Bird() : base()
        {
            speed = random.Next(1, 20);
        }

        public  void FlyTo(Point newPoint)
        {
            FinalPoint = newPoint;
            FinalPoint = newPoint;
            distance += GetDistance(newPoint,newPoint);
        }

        public double GetFlyTime()
        {
            return distance / speed;
        }

        public string WhoAmI()
        {
            return "it's a Bird";
        }
    }
}