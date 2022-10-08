using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio
{
    public class Region
    {
        public int Id { get; set; }
        public static int UltimoId { get; set; }
        public string NombreContinente { get; set; } //ToDo enummmm!!!!!

        public void ValidarNombre()
        {
            if (string.IsNullOrEmpty(NombreContinente))
            {
                //throw new Exception("La region debe tener un nombre valido")
            }

        }
    }
}
