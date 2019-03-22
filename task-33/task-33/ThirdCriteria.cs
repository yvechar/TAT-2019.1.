using System.Collections.Generic;


namespace task_33
{
/// <summary>
/// 3 criteria : minimum number of staff qualifications higher than junior for fixed productivity
/// </summary>
    public class ThirdCriteria : Optimazer
    {
        public ThirdCriteria(int input_productivity)
        {
            this.input_productivity = input_productivity;
        }

        public class SecondCriteria : Optimazer
        {
           
            public List<Employee> GetThirdCriteria(int input_money_amount, int input_productivity)
            {

                while (productivity_amount < input_productivity)
                {

                    int j_s_koef = junior.GetSalary() / junior.GetProductivity();
                    int m_s_koef = middle.GetSalary() / middle.GetProductivity();
                    int s_s_koef = senior.GetSalary() / senior.GetProductivity();
                    int l_s_koef = lead.GetSalary() / lead.GetProductivity();
                    if (m_s_koef < s_s_koef)
                    {

                        List.Add(middle);
                        criteria_amount += middle.GetSalary();
                        productivity_amount += middle.GetProductivity();

                    }
                    else
                    {

                        List.Add(senior);
                        criteria_amount += senior.GetSalary();
                        productivity_amount += senior.GetProductivity();

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
}
