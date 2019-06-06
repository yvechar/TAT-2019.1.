
namespace currencyrate
{
    class EntryPoint
    {
        /// <summary>
        /// The method to write info to the file
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
 
            CreateDriver driver=new CreateDriver();
            WriterFile writerfile=new WriterFile();

            ICreater creater = driver.GetDriver(args[1]);
            IWriter writer = writerfile.GetWriter(args[0]);
            CurrencyPage Page = new CurrencyPage(creater.Create());
            writer.Write(Page.GetCurrency());

        }
    }
}
