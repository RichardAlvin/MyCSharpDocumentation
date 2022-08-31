using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsGuide
{
    public class Element
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public int AtomicNumber { get; set; }

/*        public static void IterateThruDictionary()
        {
            Dictionary<string, Element> elements = BuildDictionary();

            foreach (KeyValuePair<string, Element> kvp in elements)
            {
                Element theElement = kvp.Value;

                Console.WriteLine("key: " + kvp.Key);
                Console.WriteLine("values: " + theElement.Symbol + " " +
                    theElement.Name + " " + theElement.AtomicNumber);
            }
        }*/
    }
}
