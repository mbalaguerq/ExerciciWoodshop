using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230206_Exercici_Objectes_Woodshop
{
    internal class Client
    {
        private String nif;
        private String nom;

        public string Nif { get => nif; set => nif = value; }
        public string Nom { get => nom; set => nom = value; }

        public override string ToString()
        {
            return "nom" + nom + "\nnif" + nif   ;
        }

    }
}
