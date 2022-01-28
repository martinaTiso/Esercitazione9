using GestioneSpesa.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneSpesa.Entities
{
    internal class Viaggio : ICategoria
    {
        private int importoRimborsato;
        private int importo;

        
        public int Importo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ImportoRimborsato { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Viaggio(int importo, int importoRimborsato)
        {
            Importo = importo;
           this.importoRimborsato = importoRimborsato;
        }
        public ICategoria GetRimborso()
        {
            importoRimborsato = importo + 50;
            return new Viaggio( importoRimborsato,importo);
        }
    }
}
