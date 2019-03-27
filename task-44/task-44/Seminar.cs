using System;
using System.Collections.Generic;

namespace task_44
{/// <summary>
/// class Seminar
/// </summary>
    public class Seminar : BaseAbstractClass
    {
        List<string> Tasks;
        List<string> Questions;
        List<string> Answers;

        Random random = new Random();
        /// <summary>
        /// The constructor of class Seminar
        /// Add random number of Tasks,Questions,Answers to lists
        /// </summary>
        public Seminar() : base()
        {
            Tasks = new List<string>();
            Questions = new List<string>();
            Answers = new List<string>();
            
            for (int i = 0; i < random.Next(1, 15); i++)
            {
                Tasks.Add(WriteText(30));
            }
           
            for (int i = 0; i < random.Next(1, 15); i++)
            {
                Questions.Add(WriteText(20));
                Answers.Add(WriteText(30));
            }
        }
        /// <summary>
        /// override method ToString
        /// </summary>
        /// <returns>Discipline</returns>
        public override string ToString()
        {
          return "Seminar";
        }

        /// <summary>
        /// override method to compare 2 objs by their GUID
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            if (obj is BaseAbstractClass)
            {
                BaseAbstractClass disipline = (BaseAbstractClass)obj;
                return (GUID == disipline.GUID) ? true : false;
            }
            return false;
        }

        public object Clone()
        {
            Seminar clone_seminar= new Seminar();
            return clone_seminar;
            
        }
    }
}