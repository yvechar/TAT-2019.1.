using System.Collections.Generic;

namespace task_33
{/// <summary>
/// 2 criteria minimum cost with fixed productivity
/// </summary>
    public class SecondCriteria : Optimazer
    {
         
        public SecondCriteria(int input_productivity) { this.input_productivity = input_productivity; }
        public List<Employee> GetSecondCriteria(int input_money_amount, int input_productivity)
        {
            while (productivity_amount < input_productivity)
            {

                int j_s_koef = junior.GetSalary() / junior.GetProductivity();
                int m_s_koef = middle.GetSalary() / middle.GetProductivity();
                int s_s_koef = senior.GetSalary() / senior.GetProductivity();
                int l_s_koef = lead.GetSalary() / lead.GetProductivity();
                if (j_s_koef < m_s_koef)
                {

                    List.Add(junior);
                    criteria_amount += junior.GetSalary();
                    productivity_amount += junior.GetProductivity();

                }
                else
                {
                    List.Add(middle);
                    criteria_amount += middle.GetSalary();
                    productivity_amount += middle.GetProductivity();
                }
                if (s_s_koef < l_s_koef)
                {

                    List.Add(senior);
                    criteria_amount += senior.GetSalary();
                    productivity_amount += senior.GetProductivity();

                }
                else
                {
                    List.Add(lead);
                    criteria_amount += lead.GetSalary();
                    productivity_amount += lead.GetProductivity();
                }

            }
        
            return List;
        }
    }
}