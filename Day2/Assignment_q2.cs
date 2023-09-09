using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
 
    internal class Program
    {
        static void Main(string[] args)
        {
         
            FileInfo FInfo = new FileInfo(@"C:\Users\nnikhilsai\Documents\Training\Assessments\Day1\pg1.txt");
            Console.WriteLine("File Name: \"" + FInfo.Name + "\"");
            DateTime dtCreationTime = FInfo.CreationTime;
            Console.WriteLine("Date and Time of File Created: " + dtCreationTime.ToString());
            Console.WriteLine("File Size: " + FInfo.Length.ToString());
            Console.WriteLine("File Full Name: \"" + FInfo.FullName + "\"");
            Console.ReadLine();
        }
    }
}