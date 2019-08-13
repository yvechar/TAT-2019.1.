namespace currencyrate
{
    /// <summary>
    /// The class WriterFile to choose file format : json or xml
    /// </summary>
    class WriterFile
    {
        const string json="json";
        const string xml = "xml";

        /// <summary>
        /// The method returns writer
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public IWriter GetWriter(string request)
        {
            int startIndex = request.IndexOf('.');
            int lastIndex = request.IndexOf(' ');
            string formatName = request.Substring(startIndex + 1, lastIndex - startIndex - 1);
            string fileName = request.Substring(0, lastIndex);

            switch (formatName)
            {
                case json:
                    return new WriterJsonFile();
                case xml:
                    return new WriterXmlFile();
                default:
                    return null;
            }
        }
    }
}
