using System.Collections.Generic;

namespace _19._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void StampaPesci(List<string> salmoni)
            {
                foreach (string salmone in salmoni)
                {
                    Console.WriteLine(salmone);
                    
                }
                Console.WriteLine();
            }
            List<string> pesci = new List<string> { "chinnok", "coho", "pink", "sockeye" };
            StampaPesci(pesci);
            Console.WriteLine(pesci[2]);
            Console.WriteLine();
            pesci.Remove("coho");
            Console.WriteLine();
            StampaPesci(pesci);
            pesci.Remove("chinnok");
            Console.WriteLine();
            StampaPesci(pesci);
        }
    }
}
