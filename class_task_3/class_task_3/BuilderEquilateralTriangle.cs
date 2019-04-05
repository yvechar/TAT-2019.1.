namespace class_task_3
{
    class BuilderEquilateralTriangle : Builder
    {
        public BuilderEquilateralTriangle(Builder builder) : base(builder)
        { }
        public override Triangle Build(Point pointX, Point pointY, Point pointZ)
        {
            if (Check(pointX, pointY, pointZ))
            {
                return new EquilateralTriangle(pointX, pointY, pointZ);
            }
            if (Successor != null)
            {
                return Successor.Build(pointX, pointY, pointZ);
            }
         }

        protected override bool Check(Point pointX, Point pointY, Point pointZ)
        {
            //check for Equilateral triangle , if it is a Equilateral triangle return true , else false
            if ()
            {
                return true;
            }
            return false;
        }
    }
}
