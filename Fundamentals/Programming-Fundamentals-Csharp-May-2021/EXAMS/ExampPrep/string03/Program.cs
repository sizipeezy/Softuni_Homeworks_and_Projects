using System;

namespace string03
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "We are living in a<upcase> yellow submarine </ upcase >" +
                ".We don't have<upcase> anything</ upcase > else.";

            string[] arr = text.Split('>', '<', '\\', StringSplitOptions.RemoveEmptyEntries);

        }
    }
}
