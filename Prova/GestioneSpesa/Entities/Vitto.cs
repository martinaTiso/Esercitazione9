using GestioneSpesa.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneSpesa.Entities
{
    public class Vitto : ICategoria
    {
        private int importo;
        private int importoRimborsato;

        
        public int Importo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ImportoRimborsato { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Vitto(int importo,int importoRimborsato)
        {
          
            this.importo=importo;
            this.importoRimborsato= importoRimborsato;
        }
        public ICategoria GetRimborso()
        {
            Console.WriteLine("Inserire l'importo");
            importo=int.Parse(Console.ReadLine());
             importoRimborsato = importo * 70 / 100;
            return  new Vitto (importoRimborsato,importo);
        }
    }
}
