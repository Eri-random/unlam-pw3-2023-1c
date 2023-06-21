using System;
using System.Collections.Generic;

namespace Clase7.EF.IslaDelTesoro.Data.Entidades
{
    public partial class Ubicacion
    {
        public Ubicacion()
        {
            Tesoros = new HashSet<Tesoro>();
        }

        public int Id { get; set; }
        public string? Nombre { get; set; }

        public virtual ICollection<Tesoro> Tesoros { get; set; }
    }
}
