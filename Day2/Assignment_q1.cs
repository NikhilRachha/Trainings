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
            StreamReader steamReader = new StreamReader(@"C:\Users\nnikhilsai\Documents\Training\Assessments\Day1\pg1.txt");

            while (steamReader.EndOfStream == false)
            {
                Console.WriteLine(steamReader.ReadLine());
            }
            Console.ReadLine();
            steamReader.Close();
        }
    }
}