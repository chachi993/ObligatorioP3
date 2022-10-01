using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio.InterfacesRepositorios
{
    public interface IRepositorioPaises : IRepositorio<Pais>
    {
       Pais FindPaisByCodigo();
        IEnumerable<Pais> GetPaisesByRegion();
        Boolean ValidarEliminacion();
    }
}
