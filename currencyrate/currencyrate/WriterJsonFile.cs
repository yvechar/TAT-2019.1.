using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;

namespace currencyrate
{
    /// <summary>
    /// The class WriterJsonFile 
    /// </summary>
    class WriterJsonFile : IWriter
    {
      /// <summary>
      /// The method that write information to jsonfile
      /// </summary>
      /// <param name="currency">name and value of currency</param>
        public void Write(List<Currency> currency)
        {
            DataContractJsonSerializer jsonFormatter;

            using (var fs = new FileStream("currencyrate.json", FileMode.OpenOrCreate))
            {
                jsonFormatter = new DataContractJsonSerializer(typeof(List<Currency>));
                jsonFormatter.WriteObject(fs, currency);
            }
        }
    }
}
