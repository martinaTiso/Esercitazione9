using GestioneSpesa.Entities;
using GestioneSpesa.Intefaccia;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneSpesa.Factory
{
    public class AltreSistemazioniFactory : ICategoriaFactory
    {
        private int Importo;
        private int ImportoRimborsato;

        public AltreSistemazioniFactory(int importo,int importoRimborsato)
        {
            Importo=importo;
            ImportoRimborsato=importoRimborsato;

        }
        public ICategoria GetRimborso()
        {
            return new AltreSistemazioni(Importo, ImportoRimborsato);
        }
    }
}
