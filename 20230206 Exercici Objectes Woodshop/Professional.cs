using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230206_Exercici_Objectes_Woodshop
{
    internal class Professional : Client
    {
        private float descompte;

        public float Descompte { get => descompte; set => descompte = value; }

        public override string ToString()
        {
            return base.ToString() +  "descompte: " + descompte;
        }
    }
}