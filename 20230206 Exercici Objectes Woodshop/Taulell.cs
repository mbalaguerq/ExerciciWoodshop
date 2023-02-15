using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230206_Exercici_Objectes_Woodshop
{
    enum Taulells
    {
         conglomerat,
         contraxapat,
         mdf
    }

    internal class Taulell : Producte
    {
        private int ample;
        private int llarg;
        Taulells tipus_Taulell;
        //millor fer TipusTaulell tipustaulell

        public int Ample { get => ample;set => ample = value; }
        public int LLarg { get => llarg; set => llarg = value; }
        public Taulells Tipus_Taulell { get => tipus_Taulell; set => tipus_Taulell = value;} 
    }
}
