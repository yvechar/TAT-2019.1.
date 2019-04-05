namespace class_task_3
{
    class BuilderUsualTriangle : Builder
    {
        public BuilderUsualTriangle(Builder builder) : base(builder)
        { }
        public override Triangle Build(Point pointX, Point pointY, Point pointZ)
        {
             return new UsualTriangle(pointX, pointY, pointZ);
        }
    }
}
