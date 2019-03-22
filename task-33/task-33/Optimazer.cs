using System.Collections.Generic;

namespace task_33
{
    public class Optimazer : Company
    {
        protected List<Employee> List;
        public Junior junior = new Junior();
        public Middle middle = new Middle();
        public Senior senior = new Senior();
        public Lead lead = new Lead();
        public int criteria_amount;
        public int productivity_amount;
        public int input_money_amount;
        public int input_productivity;



        
        public virtual List<Employee> Choose()
        {
            return new List<Employee>();
        }
    }
}