namespace task_5
{
    /// <summary>
    /// The class SpaceShip that implements IFlyable interface and is child of  class  FlyingObject 
    /// </summary>
    public class SpaceShip : FlyingObject, IFlyable
    {
        /// <summary>
        /// The contructor of class
        /// </summary>
        public SpaceShip() : base()
        {
            speed = 8000;
        }

        public void FlyTo(Point newPoint)
        {
            FinalPoint = newPoint;
            FinalPoint = newPoint;
            distance += GetDistance(newPoint, newPoint);
        }

        public double GetFlyTime()
        { 
            return distance / speed;
        }

        public string WhoAmI()
        {
            return "it's a SpaceShip";
        }
    }
}