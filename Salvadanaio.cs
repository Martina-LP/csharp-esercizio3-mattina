using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_esercizio3_mattina
{
    internal class Salvadanaio
    {
        int totale;

        internal int Add(int valore)
        {
            totale += valore; //totale = totale + valore;
            return totale;
        }

        public Salvadanaio()
        {
            totale = 0;
        }
    }
}
