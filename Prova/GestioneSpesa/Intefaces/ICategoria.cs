using GestioneSpesa.Intefaccia;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneSpesa.Factory
{
    public interface ICategoria :ICategoriaFactory
    {
       
        int Importo { get; set; }
        int ImportoRimborsato { get; set; }
        
    }
}
