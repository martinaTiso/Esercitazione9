using GestioneSpesa.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneSpesa.Entities
{
    internal class AltreSistemazioni : ICategoria
    {
        private int importoRimborsato;
        private int importo;

       
        public int Importo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ImportoRimborsato { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public AltreSistemazioni(int importo, int importoRimborsato)
        {
            this.Importo = importo;
            this.ImportoRimborsato = importoRimborsato;
        }
        public ICategoria GetRimborso()
        {
            
            
            importoRimborsato = (importo * 30) / 100;
            return  new AltreSistemazioni(importoRimborsato,importo);
        }
    }
}
