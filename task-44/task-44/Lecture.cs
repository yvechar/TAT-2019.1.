using System;
using System.Collections.Generic;
using System.Text;

namespace task_44
{/// <summary>
/// class Lecture
/// </summary>
    public class Lecture : BaseAbstractClass
    {
        List<Seminar> Laboratory { get; }
        List<Laboratory> Seminars;
        public string MaterialForLection;
        public string URL { get; set;}
        FormatPresentasion formatPresentasion;
        Random random = new Random();

        public Lecture() : base()
        {
            MaterialForLection = WriteText(100000);
            formatPresentasion = new FormatPresentasion();
            URL = $"{WriteText(10)}.com";


           Seminars = new List<Seminar>();
           Laboratory = new List<Laboratory>();
            for (int i = 0; i < random.Next(1, 3); i++)
            {
                Seminars.Add(new Seminar());
            }
            for (int i = 0; i < random.Next(1, 6); i++)
            {
                Laboratory.Add(new Laboratory());
            }
        }
        /// <summary>
        /// Format of Presentation
        /// </summary>
        enum FormatPresentasion
        {
            PPT,
            PDF,
            Unknown
        }

        /// <summary>
        /// override method ToString
        /// </summary>
        /// <returns> Lecture</returns>

        public override string ToString()
        {
            return "Lecture";
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
                var disipline = (BaseAbstractClass)obj;
                return (GUID == disipline.GUID) ? true : false;
            }
            return false;
        }
    }
}