using System;

namespace task_5
{
    /// <summary>
    /// The class FlyingObject is ihe base class for Plane,Bird and SpaceShip  
    /// </summary>
    public class FlyingObject 
    {
        public int speed;
        public double distance;
        public Point FinalPoint;
        public Point FirstPoint;
      
        /// <summary>
        /// The contructor of class
        /// </summary>
        public FlyingObject() { }

        /// <summary>
        /// The method  GetDistance that finda distance and return it
        /// </summary>
        /// <param name="FirstPoint">point of Struct Point</param>
        /// <param name="FinalPoint">point of Struct Poin</param>
        /// <returns>distance</returns>
        public double GetDistance(Point FirstPoint,Point FinalPoint)
        {
            distance = Math.Sqrt(Math.Pow(FinalPoint.x - FirstPoint.x, 2) + Math.Pow(FinalPoint.y - FirstPoint.y, 2) + Math.Pow(FinalPoint.z - FirstPoint.z, 2));
            return distance;
        }
    }
}