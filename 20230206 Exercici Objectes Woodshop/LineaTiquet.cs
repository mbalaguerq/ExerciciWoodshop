using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230206_Exercici_Objectes_Woodshop
{
    internal class LineaTiquet
    {
        private int quantitat;
        private Producte producte;
        private float preu;

        public int Quantitat { get => quantitat; set => quantitat = value; }
        public Producte Producte { get => producte; set => producte = value; }
        public float Preu { get => preu; set => preu = value; }

        public override string ToString()
        {
            return "Producte: " + producte.Codi + "\nunitats: " 
            + quantitat + "\nPreu + " + preu;
        }
    }
}
