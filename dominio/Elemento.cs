﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Elemento
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        //sobreescribir metodo para que ToString devuelva solo la Descripcion.
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
