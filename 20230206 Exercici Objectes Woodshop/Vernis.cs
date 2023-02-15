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
        public Verniss Tipus_Vernis { get => tipus_vernis; set => tipus_vernis = value; }

        public override string ToString()
        {
            return base.ToString() + "color"  ;
        }
    }
}
