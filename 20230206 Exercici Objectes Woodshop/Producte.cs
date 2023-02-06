using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230206_Exercici_Objectes_Woodshop
{
    internal abstract class Producte
    {
        private String codi;
        private String descripcio;
        private float pvp;
        private int stock;

        public string Codi { get => codi; set => codi = value;}
        public string Descripcio { get => descripcio;set => descripcio = value;}
        public float Pvp { get => pvp;set => pvp = value;}
        public int Stock { get => stock;set => stock = value;}

        public override string ToString()
        {
            return "codi" + codi + "descripció" + descripcio + "Preu" + pvp + "Stock" + stock;
        }
    }
}
