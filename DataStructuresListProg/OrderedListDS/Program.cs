using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderedListDS
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderedListClass list = new OrderedListClass();
            string file = @"D:\BridgeLabs\DataStructuresListProg\DataStructuresListProg\OrderedListDS\OrderedTextFile.txt";
            string fileContent = "";
            if (File.Exists(file))
            {
                fileContent = File.ReadAllText(file);
            }
            string[] inputArray = fileContent.Split(' ');
            foreach (string word in inputArray)
            {
                int pos = list.Insert(Convert.ToInt32(word));                
            }
            Console.WriteLine("Displaying the content retrived from the list");
            list.Display();
            list.Sort();
            Console.WriteLine("Displaying the list after Sorting");
            list.Display();
            Console.WriteLine("Search a number if exists");
            string input =Console.ReadLine();
            int inp = Convert.ToInt32(input);
            if (inputArray.Contains(input))
            {
                list.Remove(inp);
                Console.WriteLine("{0} Removed", inp);
            }
            else
            {
                list.Insert(inp);
                Console.WriteLine("{0} Added", inp);
            }
            Console.WriteLine("Final Output of Prog");
            list.Sort();
            list.Display();
        }
    }
}
