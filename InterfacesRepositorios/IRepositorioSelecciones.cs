using ObligatorioP3;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio.InterfacesRepositorios
{
    public interface IRepositorioSelecciones: IRepositorio<Seleccion>
    {
        Boolean ValidarEliminacion();
    }
}
