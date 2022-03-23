using System;
using System.Collections;

namespace orderSorter
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList myVal = new ArrayList();
            myVal.Add("hallo");
            myVal.Add(10);
            myVal.Add("this is a string");

            foreach (var value in myVal)
            {
                Console.WriteLine(value);
            }
            
            
        }

        
    }
}