namespace task_33
{
    public class Employee
    {
     
        public Employee() { }
        public int Salary { get; protected set; }
        public int Productivity { get; protected set; }

        public Employee(int salary,int productivity)
        {
           
            GetSalary();
            GetProductivity();

        }
        virtual public int GetSalary()
        {
            return 10;
        }
        virtual public int GetProductivity()
        {
            return 10;
        }



    }
}