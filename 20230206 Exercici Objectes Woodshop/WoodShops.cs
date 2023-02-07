using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _20230206_Exercici_Objectes_Woodshop
{
    internal class WoodShops
    {
        private String nif;
        private String nombre;
        private ArrayList tenda;
        private ArrayList fabricant;

        public WoodShops()
        {
            tenda= new ArrayList();
            fabricant= new ArrayList();
        }

        public string Nif { get { return nif; } set { nif = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } } 
        public ArrayList Tenda { get { return tenda; } }
        public ArrayList Fabricant { get { return fabricant; } }

        public void AddTenda(Tenda  tenda) 
        { 
            Tenda.Add(tenda); 
        }
        public void AddFabricant(Fabricant fabricant)
        {
            Fabricant.Add(fabricant);
        }
        public Fabricant GetFabricantbyNom(string nom)
        {
            foreach(Fabricant fabricant in fabricant) 
            {
                if (fabricant.Nombre.Equals(nom)) return fabricant;
            }
            return null;
        }

    }
}
