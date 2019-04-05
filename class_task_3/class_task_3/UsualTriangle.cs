=
namespace class_task_3
{
    class UsualTriangle : Triangle
    {
        public float square;
        public UsualTriangle(Point pointX, Point pointY, Point pointZ)
            : base(pointX, pointY, pointZ)
        {
            //creat a UsualTriangle
        }

        public override float GetSquare()
        {
            //square of UsualTriangle
            return square;
        }
    }
}
