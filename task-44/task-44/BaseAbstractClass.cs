using System;
using System.IO;

namespace task_44
{      /// <summary>
      /// Base abstract class of Discipline, Lecture, Seminar and Laboratory
     /// </summary>
    public abstract class BaseAbstractClass
    {
        public string GUID { get; set; }
        public string Description { get; protected set; }
        Random random = new Random();
        /// <summary>
        /// The constructor of class BaseAbstractClass
        /// </summary>
        public BaseAbstractClass()
        {

        }
       /// <summary>
        /// Wrtiting Descriotion 
       /// </summary>
       /// <param name="limit"></param>
      /// <returns></returns>
        public string WriteText(int limit)
        {
            string TextOfDescription = null;
            char Text = TextOfDescription[random.Next(0, TextOfDescription.Length - 1)];
            return Text.ToString();
        }

        /// <summary>
        /// override method ToString
        /// </summary>
        /// <returns>Discipline</returns>
        public override string ToString()
        {
            return $"Description : {Description}";
        }

        public string GUIDToString(string guid)
        {
             return guid.ToString();
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