﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUMA_PROPIEDADES
{
    internal class SUMA
    {
        internal class cloperaciones
        {
            // Propiedades, campos, etc.
            private int n1;
            private int n2;
            
            // Encapsulamiento de las propiedades.
            public int N1 { get => n1; set => n1 = value; }
            public int N2 { get => n2; set => n2 = value; }

            // Metodo
            public int Sumar()
            {
                return n1 + n2;
            }
        }
    }
}
