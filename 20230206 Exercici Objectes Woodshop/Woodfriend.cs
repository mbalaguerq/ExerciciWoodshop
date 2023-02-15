using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230206_Exercici_Objectes_Woodshop
{
    internal class Woodfriend : Client
    {
        private int numSoci;

        public int NumSoci { get => numSoci; set => numSoci = value; }


        public override string ToString()
        {
            return base.ToString() + "Número de soci: \t" + numSoci;
        }
    }
}
