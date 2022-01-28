using GestioneSpesa.Entities;
using GestioneSpesa.Intefaccia;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneSpesa.Factory
{
    public class VittoFactory : ICategoriaFactory
    {
      
        private int ImportoRimborsato;
        private int Importo;

       

        public VittoFactory(int importoRimborsato, string nome,int importo)

        {
          
            Importo=importo;
            ImportoRimborsato = importoRimborsato;
        }

        public ICategoria GetRimborso()
        {
            return new Vitto(Importo,ImportoRimborsato);
        }
    }
}
