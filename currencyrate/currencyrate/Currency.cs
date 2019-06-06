using System;
using System.Runtime.Serialization;

namespace currencyrate
{
    /// <summary>
    /// The class Currency has properties of currency
    /// </summary>
    [DataContract]
    [Serializable()]
    class Currency
    {
        [DataMember]
        public string Name;
        [DataMember]
        public string Value;

        /// <summary>
        /// The constructor of Currency
        /// </summary>
        /// <param name="name">name of currency</param>
        /// <param name="value">value of currency</param>
        public Currency(string name, string value)
        {
            this.Name = name;
            this.Value = value;
        }
    }
}
