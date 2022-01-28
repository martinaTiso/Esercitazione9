using GestioneSpesa.Entities;
using GestioneSpesa.Intefaccia;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneSpesa.Factory
{
    public class ViaggioFactory : ICategoriaFactory
    {
       
        private int Importo;
        private int ImportoRimborsato;

        public ViaggioFactory(int importo,int importoRimborsato)
        {
            Importo=importo;
            ImportoRimborsato=importoRimborsato;
        }
        public ICategoria GetRimborso()
        {
            return new Viaggio(Importo, ImportoRimborsato);
        }
    }
   
}

