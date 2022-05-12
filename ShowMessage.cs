using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_esercizio3_mattina
{
    internal class ShowMessage
    {
        public static void AppendMessage(string testo)
        {
            //Prima implementazione (ricorsiva)
            //if(testo.Length > 10)
            //{
            //    Console.WriteLine(testo.Substring(0, 10));
            //    AppendMessage(testo.Substring(10));
            //} else
            //{
            //    Console.WriteLine(testo);
            //}

            //Seconda implementazione (iterativa)
            //while (testo.Length > 10)
            //{
            //    Console.WriteLine(testo.Substring(0, 10));
            //    testo = testo.Substring(10);
            //}
            //Console.WriteLine(testo);

            //Terza implementazione (iterativa sui singoli caratteri)
            int pos = 0;
            foreach (char c in testo)
            {
                if (pos == 10)
                {
                    Console.WriteLine();
                    pos = 0;
                }
                Console.Write(c);
                pos++;
            }
        }
    }
}
