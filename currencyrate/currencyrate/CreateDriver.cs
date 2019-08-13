
namespace currencyrate
{
    /// <summary>
    /// The class CreateDriver to create web driver
    /// </summary>
    class CreateDriver
    {
         const string chromename="chrome";
         const string operaname = "opera";

        /// <summary>
        /// The method returns driver
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public IWriter GetDriver(string request)
        {
            int startIndex = request.IndexOf(' ');
            string driverName = request.Substring(startIndex + 1);

            switch (driverName)
            {
                case chromename:
                    return new ChromeDriverCreator();
                case operaname:
                    return new OperaDriveCreatorr();
                default:
                    return null;
            }
        }

    }
}
