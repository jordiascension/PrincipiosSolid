﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.SingleResponsability.Incorrecto
{
    public class Coche
    {
        String marca;

        Coche(String marca) { this.marca = marca; }

        String getMarcaCoche() { return marca; }

        void guardarCocheDB(Coche coche)
        {

        }
    }
}
