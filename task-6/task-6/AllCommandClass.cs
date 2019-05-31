using System;
using System.Collections.Generic;
using System.Xml;

namespace task_6
{
    /// <summary>
    /// The class  AllCommandClass contain description of all commands
    /// </summary>
    class AllCommandClass
    {
        XmlDocument xDoc { get; }

        /// <summary>
        /// The constructor of  class
        /// </summary>
        /// <param name="file_name">name of xml file</param>
        public AllCommandClass (string file_name)
        {
            this.xDoc = new XmlDocument();
            xDoc.Load(file_name);
        }

        /// <summary>
        /// Method Get_Types gets number of car brands
        /// </summary>
        public void Get_Types()
        {
            XmlElement xRoot = xDoc.DocumentElement;
            List<string> types = new List<string>();
            foreach (XmlNode xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "brand")
                    {
                        if (!types.Contains(childnode.InnerText))
                        {
                            types.Add(childnode.InnerText);
                        }
                    }
                }
                Console.WriteLine("Types:... " + types.Count);
            }
        }

        /// <summary>
        /// Method Get_Count gets total number of cars
        /// </summary>
        public void Get_Count()
        {
            XmlElement xRoot = xDoc.DocumentElement;
            int count = 0;       
            foreach (XmlNode xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "amount")
                    {
                        count += Int32.Parse(childnode.InnerText);
                    }

                }
                Console.WriteLine("All Amount:... " + count);
            }
        }

        /// <summary>
        ///  Method  Get_AveragePrice get average cost of a car
        /// </summary>
        public void Get_AveragePrice()
        {
            XmlElement xRoot = xDoc.DocumentElement;
            int price = 0;
            int count = 0;
            int averige_price = 0;
            foreach (XmlNode xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "price")
                    {
                        price += Int32.Parse(childnode.InnerText);
                        count++;
                    }
                    averige_price = price / count;
                }
                Console.WriteLine("Averige price:... " + averige_price);
            }
        }

        /// <summary>
        /// Method  Get_AveragePriceType get average cost of a car of type
        /// </summary>
        public void Get_AveragePriceType()
        {
            XmlElement xRoot = xDoc.DocumentElement;
            int price = 0;
            int count = 0;
            int averige_price = 0;
            foreach (XmlNode xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "amount")
                    {
                        foreach (XmlNode childnode2 in xnode.ChildNodes)
                        {
                            if (childnode.Name == "price")
                            {
                                price += Int32.Parse(childnode.InnerText);
                                count++;
                            }
                            averige_price = price / count;
                        }
                    }
                }
                Console.WriteLine("Averige price:... " + averige_price);
            }
        }
    }
}
