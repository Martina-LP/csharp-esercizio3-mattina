using System;

namespace csharp_esercizio3_mattina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowMessage.AppendMessage("Nel mezzo del cammin di nostra vita mi ritrovai per una selva oscura...");

            //Questo funziona con classe e metodi statici (un solo borsellino)
            {
                //Due modi di leggere a terminale un numero e assegnarlo a una variabile
                int valore;
                //while (int.TryParse(Console.ReadLine(), out valore))
                string sValore = Console.ReadLine();
                valore = Convert.ToInt32(sValore);
                while (valore != 0)
                {
                    Console.WriteLine(Borsellino.Add(valore));
                    sValore = Console.ReadLine();
                    valore = Convert.ToInt32(sValore);
                }
            }

            //Questo funziona con N borsellini (classe e metodi statici)
            {
                Salvadanaio salvad1 = new Salvadanaio();
                Salvadanaio salvad2 = new Salvadanaio();

                int valore;
                while (int.TryParse(Console.ReadLine(), out valore))
                {
                    Console.WriteLine("1: {0}", salvad1.Add(valore));
                    valore = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("2: {0}", salvad2.Add(valore));
                }
            }
        }
    }

    /*Aggiungete una classe che forma un borsellino, ogni volta
     * che chiamo il metodo Add(valore) il borsellino si incrementa
     * del valore passato come parametro e lo stampa a schermo.
     * La classe la chiameremo Borsellino e il metodo int Add(int valore);
     */
}
