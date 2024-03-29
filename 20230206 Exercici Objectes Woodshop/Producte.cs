﻿using System;
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
        private Fabricant fabricant;

        public string Codi { get => codi; set => codi = value; }
        public string Descripcio { get => descripcio; set => descripcio = value; }
        public float Pvp { get => pvp; set => pvp = value; }
        public int Stock { get => stock; set => stock = value; }
        public Fabricant Fabricant { get => fabricant; set => fabricant = value; }


        public override string ToString()
        {
            return "Codi: " + codi + "\nDescripció: " + descripcio + "\nPreu: " + pvp + "\nStock: "
                + stock + "\nFabricant: " + Fabricant.Nombre;
        }
    }
}
