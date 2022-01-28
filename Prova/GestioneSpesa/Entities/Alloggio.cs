using GestioneSpesa.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneSpesa.Entities
{
    public class Alloggio : ICategoria
    {
        private int importoRimborsato;
        private int importo;


        public int Importo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int ImportoRimborsato { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Alloggio(int importo, int importoRimborsato)
        {
            Importo = importo;
            ImportoRimborsato = importoRimborsato;

        }



        public ICategoria GetRimborso()
        {
            importoRimborsato = importo;
            return new Alloggio(importoRimborsato, importo);
        }
    }
}
