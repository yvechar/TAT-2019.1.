namespace task_33
{
   public class Junior:Employee
    {
        public Junior ()
        {
        }
        public override int GetSalary()
        {
            return 10*2;
        }
        public override int GetProductivity()
        {
            return 10*2;
        }
        public void WriteCode() { }
    }
}