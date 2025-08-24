using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using PhonePadTest.Utils;

namespace PhonePadTest
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Please input your message:");
            string input = Console.ReadLine();
            Console.WriteLine(Conversion.OldPhonePad(input));
        }
    }
}  
