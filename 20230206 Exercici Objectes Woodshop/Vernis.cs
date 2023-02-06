using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230206_Exercici_Objectes_Woodshop
{
    enum Verniss
    {
        incolor,
        noguera,
        caoba,
        cirerer
    }

    internal class Vernis : Producte
    {
        private int ml;
        private Verniss tipus_vernis;

        public int Ml { get => ml; set => ml = value; }
        public Verniss Tipus_Vernis { get => Tipus_Vernis; set => Tipus_Vernis = value; } 
            
    }
}
