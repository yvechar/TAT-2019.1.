namespace class_task_3
{
    class BuilderRectangularTriangle : Builder
    {
        public BuilderRectangularTriangle(Builder builder) : base(builder)
        { }
          public override Triangle Build(Point pointX, Point pointY, Point pointZ)
        {
            if (Check(pointX, pointY, pointZ))
            {
                return new RectangularTriangle(pointX, pointY, pointZ);
            }
            if (Successor != null)
            {
                return Successor.Build(pointX, pointY, pointZ);
            }
        }

        protected override bool Check(Point pointX, Point pointY, Point pointZ)
        {
            //check for rectangular triangle , if it is a rectangular triangle return true , else false
            if ()
            {
                return true;
            }
            return false;
        }
    }
}

