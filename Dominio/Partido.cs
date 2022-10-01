﻿using System;
using ObligatorioP3;
using System.Collections.Generic;
using LogicaNegocio;
using LogicaNegocio.InterfacesDominio;

namespace ObligatorioP3
{
    public class Partido : IValidacion
    {
        public int Id { get; set; }
        public static int UltimoId { get; set; }
        public Seleccion EquipoUno { get; set; }
        public Seleccion EquipoDos { get; set; }
        public DateTime Fecha { get; set; }
        public int Hora { get; set; }
        public int CantidadGolesEquipoUno { get; set; }
        public int CantidadGolesEquipoDos { get; set; }
        public IEnumerable<Tarjeta> tarjetas { get; set; }
        public int PuntajeEquipoUno { get; set; }
        public int PuntajeEquipoDos { get; set; }
        public Fase Fase { get; set; }

        public void Validar()
        {
            throw new NotImplementedException();
        }
    }
}
