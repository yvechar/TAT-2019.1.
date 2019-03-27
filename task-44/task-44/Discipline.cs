using System;
using System.Collections.Generic;

namespace task_44
{/// <summary>
/// class Discipline
/// </summary>
    public class Discipline : BaseAbstractClass
    {
        List<Lecture> lecture_list = new List<Lecture>();
        List<Seminar> seminar_list = new List<Seminar>();
        List<Laboratory> laboratory_list = new List<Laboratory>();
        Random random = new Random();

        /// <summary>
        /// The constructor of class Discipline
        /// Add random number of lectures,seminars,laboratories to lists
        /// </summary>
        public Discipline() : base()
        {
            
            for (int i = 0; i < random.Next(1, 54); i++)
            {
                lecture_list.Add(new Lecture());
            }

            for (int i = 0; i < random.Next(1, 54); i++)
            {
                seminar_list.Add(new Seminar());
            }

            for (int i = 0; i < random.Next(3, 28); i++)
            {
                laboratory_list.Add(new Laboratory());
            }
        }

        /// <summary>
        /// override method ToString
        /// </summary>
        /// <returns>Discipline</returns>
        public override string ToString()
        {
          return "Discipline";
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

    }
}