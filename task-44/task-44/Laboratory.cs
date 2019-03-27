using System;

namespace task_44
{/// <summary>
/// class Laboratory
/// </summary>
    public class Laboratory : BaseAbstractClass
    {
        /// <summary>
        /// The constructor of class Laboratory
        /// </summary>
        public Laboratory() : base() { }

        /// <summary>
        /// Th constructor
        /// </summary>
        /// <param name="originalGUID"></param>
        /// <param name="originalDescription"></param>
        public Laboratory(string originalGUID, string originalDescription)
        {
            GUID = originalGUID;
            Description = originalDescription;
        }

        /// <summary>
        /// truing to do deep cloning 
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            Laboratory laboratoryClone = new Laboratory(GUID, Description);
            return laboratoryClone;
        }

        /// <summary>
        /// override method ToString
        /// </summary>
        /// <returns> Laboratory </returns>
        public override string ToString()
        {
           return "Laboratory";
        }

       
    }
}