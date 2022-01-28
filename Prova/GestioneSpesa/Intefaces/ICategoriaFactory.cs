using GestioneSpesa.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneSpesa.Intefaccia
{
    public interface ICategoriaFactory
    {
       public ICategoria GetRimborso();
    }
}
