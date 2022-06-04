using System;
using System.Collections;
using System.Collections.Generic;

namespace UnOrderedListDS
{
    class Program
    {
        static void Main(string[] args)
        {            
            UnOrderedClass list = new UnOrderedClass();            
            string file = @"D:\BridgeLabs\DataStructuresListProg\DataStructuresListProg\UnOrderedListDS\UnOrderedTextFile.txt";
            string fileContent = "";
            if (File.Exists(file))
            {
                fileContent = File.ReadAllText(file);
            }
            string[] fileArray = fileContent.ToLower().Split(' ');
            foreach (string word in fileArray)
            {
                list.Add(word);
            }
            list.Display();            
            Console.WriteLine("Search a word if it exists in the file");
            string find = Console.ReadLine();
            if (fileArray.Contains(find))
            {
                list.Remove(find);
            }                
            else
            {
                list.Add(find);
            }
            list.Display();
            
        }
    }
}