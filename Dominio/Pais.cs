using System;
using ObligatorioP3;
using System.Collections.Generic;
using System.Text;
using LogicaNegocio.InterfacesDominio;

namespace LogicaNegocio
{
    public class Pais : IValidacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string CodigoISOAlfa3 { get; set; }
        public double Pbi { get; set; }
        public int Poblacion { get; set; }

        public string Imagen { get; set; }
        public Region Region { get; set; }

        public void Validar()
        {
            ValidarNombre();
        }
        public void ValidarNombre()
        {
        }
    }
}
