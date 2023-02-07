using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _20230206_Exercici_Objectes_Woodshop
{
    internal class Fabricant
    {
        private String nif;
        private String nombre;

        public string Nif { get => nif; set => nif = value; }
        public string Nombre { get => nombre;set => nombre = value; }
    }  
}
