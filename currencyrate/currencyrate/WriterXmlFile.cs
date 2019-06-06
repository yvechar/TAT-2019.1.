using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace currencyrate
{
    /// <summary>
    /// The class WriterXmlFile
    /// </summary>
    class WriterXmlFile :  IWriter
    {
        /// <summary>
        /// The method that write information to xmlfile
        /// </summary>
        /// <param name="currency">name and value of currency</param>
        public void Write(List<Currency> currency)
        {
            XmlSerializer formatter;

            using (var fs = new FileStream("currency.xml", FileMode.OpenOrCreate))
            {
                formatter = new XmlSerializer(typeof(List<Currency>));
                formatter.Serialize(fs, currency);
            }
        }
    }
}
