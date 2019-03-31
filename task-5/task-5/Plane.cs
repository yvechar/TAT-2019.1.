namespace task_5
{
    public class Plane : FlyingObject, IFlyable
    {
        /// <summary>
        /// The class Plane that implements IFlyable interface and is child of  class  FlyingObject 
        /// </summary>
        public double FlyTime;

        /// <summary>
        /// The contructor of class
        /// </summary>
        public Plane() : base()
        {
            speed = 200;
            distance = 10;
        }

        public void FlyTo(Point newPoint)
        {
            FirstPoint = newPoint;
            FinalPoint = newPoint;
            distance += GetDistance(newPoint,newPoint);
        }

        public double GetFlyTime()
        {
            while (distance<=10)
            {
                speed += 10;
                FlyTime += distance / speed;
                distance -= distance;
            }

            return FlyTime;
        }

        public string WhoAmI()
        {
            return "it's a plane";
        }
    }
}