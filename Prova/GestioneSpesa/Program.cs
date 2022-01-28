using GestioneSpesa.Factory;
using System;
using System.Collections.Generic;
using System.IO;

namespace GestioneSpesa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line;
            try
            {
                //Passa il file path and file name al StreamReader constructor
                StreamReader sr = new StreamReader(@"C:\\Users\martina.tiso\Desktop\EsercitazioneWeek9\GestioneSpesa\Spese.txt");
                //Legge la prima riga di testo
                line = sr.ReadLine();
                //Continue fino alla fine delle righe
                while (line != null)
                {
                    
                    Console.WriteLine(line);
                    
                    line = sr.ReadLine();
                }
                // chiude il file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
        // metodo controllo spesa
        public bool ControlloSpesa(int importo)
        {
            List<string> spese = new List<string>();
            
            foreach (string rw in spese)
            {
                Console.WriteLine("inserire importo:");
                importo=int.Parse(Console.ReadLine());

                if (importo <= 2500)
                {
                    Console.WriteLine("spesa approvata");

                }
                else Console.WriteLine("Spesa non approvata");
            }
            return true;

            
        }
    }

       
}
