using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticipentDetails1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string s = ",";
            StringBuilder sb = new StringBuilder();

            Console.WriteLine("ENTER THE NAME");
            sb.Append(Console.ReadLine());
            sb.Append(",");

            Console.WriteLine("ENTER THE EMPnO");
            sb.Append(Console.ReadLine());
            sb.Append(",");

            Console.WriteLine("ENTER THE DESIGNATION");
            sb.Append(Console.ReadLine());
            sb.Append(",");
           
            Console.WriteLine("ENTER THE EXPERIENCE");
            sb.Append(Console.ReadLine());
            sb.Append(",");

            Console.WriteLine("ENTER THE QUALIFICATION");
            sb.Append(Console.ReadLine());

            Console.WriteLine(sb);

        }
    }
}
