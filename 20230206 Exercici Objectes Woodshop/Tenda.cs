using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230206_Exercici_Objectes_Woodshop
{
    internal class Tenda
    {
        private String direccio;
        private String poblacio;
        private ArrayList producte;

        public Tenda()
        {
            producte = new ArrayList();
        }

        public string Direccio { get { return direccio; } set { direccio = value; } }
        public String Poblacio { get { return poblacio; } set { poblacio = value; } }
        public ArrayList Producte { get { return producte; } }
        //si no faig el set, em dona error

        public void AddProducte(Producte producte) 
        { 
            Producte.Add(producte); 
        }
        public string GetproductebyTipus(Producte producte, string opcio)
        {
            foreach ()
        }
    }
}
