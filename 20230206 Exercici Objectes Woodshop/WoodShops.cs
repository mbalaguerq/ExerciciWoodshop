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
        private ArrayList arraytenda;
        private ArrayList fabricant;
        private ArrayList arrayClient;

        public WoodShops()
        {
            arraytenda= new ArrayList();
            fabricant= new ArrayList();
            arrayClient= new ArrayList();

        }

        public string Nif { get { return nif; } set { nif = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } } 
        public ArrayList Tenda { get { return arraytenda; } }
        public ArrayList Fabricant { get { return fabricant; } }
        public ArrayList ArrayClient { get { return arrayClient; } }

        public void AddTenda(Tenda  tenda) 
        { 
            Tenda.Add(tenda); 
        }

        public void AddClient(Client client)
        {
            ArrayClient.Add(client);
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
        public Tenda GetTendabyPoblacio(string nom)
        {
            foreach (Tenda t in arraytenda)
            {
                if (t.Poblacio.Equals(nom))
                { return t; }
                
            }
            return null;
        }
        public Client GetClientByNif(string nif)
        {
            foreach (Client client in arrayClient) 
            {
                if (client.Nif.Equals(nif))
                {
                    return client;
                }
            }
            return null;
        }

    }
}
