using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses8523
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\AbstractClasses8523\AbstractClasses8523\File.txt";
            FileOperationBase fileOperation = new FileOperation()
            { 
                Path = path 
            };
            Console.WriteLine(fileOperation.GetPath());
            Console.WriteLine("**********");
            string content = fileOperation.ReadFromFile();
            Console.WriteLine(content);
            Console.WriteLine("**********");
            Console.WriteLine("Enter content: ");
            string input = Console.ReadLine();

            fileOperation.WriteToFile(input);
            Console.WriteLine("**********");
            content = fileOperation.ReadFromFile();
            Console.WriteLine(content);

            Console.ReadLine();
        }
    }
}
