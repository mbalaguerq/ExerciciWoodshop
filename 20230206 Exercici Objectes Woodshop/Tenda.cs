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
        private ArrayList arrayTiquetventa;

        public Tenda()
        {
            producte = new ArrayList();
            arrayTiquetventa = new ArrayList();
        }
        public string Direccio { get { return direccio; } set { direccio = value; } }
        public String Poblacio { get { return poblacio; } set { poblacio = value; } }
        public ArrayList Producte { get { return producte; } }
        public ArrayList ArrayTiquetventa { get { return arrayTiquetventa; } }

        public void AddTiquet(TiquetVenta tiquetVenta)
        {
            arrayTiquetventa.Add(tiquetVenta);
        }

        public void AddProducte(Producte producte)
        {
            Producte.Add(producte);
        }
        public void GetproductebyTipus(int opcio)
        {
            if (opcio == 3)
            {
                foreach (Producte pro in Producte)
                {
                    if (pro is Vernis)
                    {
                        Console.WriteLine(pro.Codi);
                        Console.WriteLine(pro.Descripcio);
                    }
                }
            }
            if (opcio == 2)
            {
                foreach (Producte pro in Producte)
                {
                    if (pro is Article)
                    {
                        Console.WriteLine(pro.Codi);
                        Console.WriteLine(pro.Descripcio);
                    }
                }
            }
            if (opcio == 1)
            {
                foreach (Producte pro in Producte)
                {
                    if (pro is Taulell)

                    {
                        Console.WriteLine(pro.Codi);
                        Console.WriteLine(pro.Descripcio);
                    }
                }
            }

        }
        public Producte GetproductebyCodi(string codi)
        {
            foreach (Producte pro in Producte)
            {
                if (codi == pro.Codi)
                {
                    return pro;

                }
            }
            return null;
        }
        public TiquetVenta GetTiquetbyCodi(int codi)
        {
            foreach (TiquetVenta tic in arrayTiquetventa)
            {
                if (codi == tic.Numero)
                {
                    return tic;

                }
            }
            return null;
        }
    }
}
