using System;

namespace Reverse
{
    class Program
    {
        public static void Main()
        {
            string str= "Robert";
            Reverse stringObj = new Reverse();
            stringObj.displayReverse(str); 
            Console.ReadKey();
        }
    }
    class Reverse
    {
        public void displayReverse(string str)
        {
            if (str.Length > 0)
            {
                Console.WriteLine(str);
                displayReverse(str.Substring(1, str.Length - 1));
               
            }
            else
            {
                return;
            }
            Console.Write(str[0]);
        }
    }
}