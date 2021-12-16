using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace DictionaryCode
{
    class dictionary
    {
	    //store the elements in Dictionary
          public void AddElements()
          {
                Dictionary<int, string> list = new Dictionary<int, string>();
                list.Add(1, "i ");
                list.Add(2, "am");
                list.Add(3, "a");
                list.Add(4, "good");
                list.Add(5, "person");
                Console.WriteLine(" before remove:" + list.Count);
                foreach (KeyValuePair<int, string> str in list)
                {

                    Console.WriteLine("{0} and {1}", str.Key, str.Value);
                    // Console.WriteLine("inserting the elements: " + key + " " + value);
                }
		//remove method
            list.Remove(1);
            Console.WriteLine(" after remove:" + list.Count);
            //remove multipul elements
            int count = list.Count;
                for (int i = 1; i < list.Count; i++)
                {

                    if (i < 3)
                    {
                        string ch = Convert.ToString(i);
                        Console.WriteLine("remove elaents:" + i);
                    }
                }
                Console.WriteLine("----->" + list.Count);
                foreach (KeyValuePair<int, string> str in list)
                {
                    Console.WriteLine("{0} and {1}", str.Key, str.Value);
                }
          }
     }
}


