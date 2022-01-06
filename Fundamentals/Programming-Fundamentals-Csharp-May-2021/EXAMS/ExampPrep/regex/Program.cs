using System;
using System.Text.RegularExpressions;

namespace regex
{
    class Program
    {
        static void Main(string[] args)
        {
            string doc = "Smith's number: 0898880022\nFranky can be " +     " found at 0888445566.\nSteven’s mobile number: 0887654321";
            string replacedDoc = Regex.Replace(doc, "(08)[0-9]{8}", "$1********");
            Console.WriteLine(replacedDoc);
        }
    }
}
