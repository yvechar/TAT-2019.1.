namespace task_33
{
    public class Lead : Senior
    {
        public Lead()
        {
        }
        public override int GetSalary()
        {
            return 10 * 4;
        }
        public override int GetProductivity()
        {
            return 10 * 5;
        }
        public void Manage() { }
    }
}