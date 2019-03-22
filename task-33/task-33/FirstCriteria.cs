using System.Collections.Generic;

namespace task_33
{
    /// <summary>
    /// 1  criteria maximum productivity within the sum
    /// </summary>
    public class FirstCriteria : Optimazer
    {

        public FirstCriteria(int input_money_amount) { this.input_money_amount = input_money_amount; }
        public List<Employee> GetFirstCriteria(int input_money_amount)
        {

            while (criteria_amount < input_money_amount)
            {
                if (lead.GetSalary() < input_money_amount)
                {
                    List.Add(lead);
                    criteria_amount -= lead.GetSalary();
                    productivity_amount += lead.GetProductivity();

                }

                if (senior.GetSalary() < input_money_amount)
                {
                    List.Add(senior);
                    criteria_amount -= senior.GetSalary();
                    productivity_amount += senior.GetProductivity();

                }
                if (middle.GetSalary() < input_money_amount)
                {
                    List.Add(middle);
                    criteria_amount -= middle.GetSalary();
                    productivity_amount += middle.GetProductivity();

                }
                if (junior.GetSalary() < input_money_amount)
                {
                    List.Add(junior);
                    criteria_amount -= junior.GetSalary();
                    productivity_amount += junior.GetProductivity();

                }
                 }
            return List;
        }

    }
}