﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Carreta:Vehiculo
    {
        public Carreta(string patente):base(patente)
        { }

        public override float CalcularCosto()
        {
            return 5f;
        }
    }
}
