using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230206_Exercici_Objectes_Woodshop
{
    internal class Aplicacio
    {
        WoodShops woodShops = new WoodShops();

        public void Inici()
        {
            bool salir = false;
            string opcio;

            do
            {
                mostrarMenu();
                opcio = DemanarOpcioMenu();
                salir = ExecutarMenu(opcio);

            } while (!salir);
            Console.WriteLine();
        }

        public void mostrarMenu()
        {
            Console.WriteLine("1. Càrrega de productes a la tenda ");
            Console.WriteLine("2. Llistat de productes de botiga");
            Console.WriteLine("3. Stock de producte per tenda");
        }
        public string DemanarOpcioMenu()
        {
            string opcio;
            do
            {
                Console.Write("Sel.lecciona opció: ");
                opcio = Console.ReadLine();
            } while (!"0123456".Contains(opcio));
            return opcio;
        }

        bool ExecutarMenu(String opcio)
        {
            bool salir = false;
            switch (opcio)
            {
                case "1":
                    CarregaProductes(woodShops);
                    break;
                case "2":
                    StockTenda(woodShops);
                    break;
                case "3":
                    StockProducte(woodShops);
                    break;

                case "0":
                    salir = true;
                    break;
            }
            return salir;
        }
        void CarregaProductes(WoodShops woodShops)
        {
            //Creem obj tenda i els afegim a l'array Woodshops
            Tenda barcelona = new Tenda();
            barcelona.Direccio = "Sagrada Familia 23";
            barcelona.Poblacio = "Barcelona";

            Tenda girona = new Tenda();
            girona.Direccio = "Carrer del Call";
            girona.Poblacio = "Girona";

            Tenda badalona = new Tenda();
            badalona.Direccio = "CC Magic SN";
            badalona.Poblacio = "Badalona";

            woodShops.AddTenda(barcelona);
            woodShops.AddTenda(girona);
            woodShops.AddTenda(badalona);


            //Creem els obj. fabricants i els afegim a l'Array fabricants
            Fabricant ikea = new Fabricant();
            ikea.Nombre = "Ikea";
            ikea.Nif = "123456789";

            Fabricant kibuc = new Fabricant();
            kibuc.Nombre = "Kibuc";
            kibuc.Nif = "987654321";

            Fabricant mobelinde = new Fabricant();
            mobelinde.Nombre = "Mobelinde";
            mobelinde.Nif = "123654789";

            Fabricant facilmobel = new Fabricant();
            facilmobel.Nombre = "Facilmobel";
            facilmobel.Nif = "321456987";

            woodShops.AddFabricant(ikea);
            woodShops.AddFabricant(kibuc);
            woodShops.AddFabricant(facilmobel);
            woodShops.AddFabricant(mobelinde);


            //Creem els obj producte i els afegim a l'array botiga. A cada botiga
            Taulell taulell1 = new Taulell();
            taulell1.Tipus_Taulell = Taulells.mdf;
            taulell1.Ample = 15;
            taulell1.LLarg = 100;
            taulell1.Codi = "STR*2512";
            taulell1.Descripcio = "Tauló fusta mdf Q1";
            taulell1.Pvp = 12;
            taulell1.Stock = 100;
            taulell1.Fabricant = woodShops.GetFabricantbyNom("Ikea");

            Taulell taulell2 = new Taulell();
            taulell2.Tipus_Taulell = Taulells.contraxapat;
            taulell2.Ample = 25;
            taulell2.LLarg = 90;
            taulell2.Codi = "STR*2812";
            taulell2.Descripcio = "Tauló fusta contrax. Q2";
            taulell2.Pvp = 9;
            taulell2.Stock = 70;
            taulell2.Fabricant = woodShops.GetFabricantbyNom("Mobelinde");

            Article article1 = new Article();
            article1.Tipus_Article = Articles.llit;
            article1.Codi = "PIC*FLEXIMAX";
            article1.Descripcio = "Matalàs + Somier + coixíns visco ";
            article1.Pvp = 299;
            article1.Stock = 25;
            article1.Fabricant = woodShops.GetFabricantbyNom("Kibuc");

            Vernis vernis1 = new Vernis();
            vernis1.Ml = 125;
            vernis1.Tipus_Vernis = Verniss.incolor;
            vernis1.Codi = "VAL*MATEMALTE";
            vernis1.Descripcio = "Vernis incolor ref.12534 ";
            vernis1.Pvp = 25;
            vernis1.Stock = 10;
            vernis1.Fabricant = woodShops.GetFabricantbyNom("Facilmobel");

            barcelona.AddProducte(vernis1);
            barcelona.AddProducte(article1);
            barcelona.AddProducte(taulell1);
            barcelona.AddProducte(taulell2);

            girona.AddProducte(article1);
            girona.AddProducte(taulell1);
            girona.AddProducte(taulell2);
            girona.AddProducte(vernis1);

            badalona.AddProducte(vernis1);
            badalona.AddProducte(article1);
            badalona.AddProducte(taulell1);
            badalona.AddProducte(taulell2);
        }
        void StockTenda(WoodShops woodShops)
        {
            int opcio;
            int tenda;
            //Listar los productos de una tienda
            //con la opción de seleccionar por los
            //tres tipos de producto: tablero, barniz o artículo.

            Console.WriteLine("Selecciona la tenda: ");
            Console.WriteLine("1- Barcelona");
            Console.WriteLine("2-Girona");
            Console.WriteLine("3-Badalona");
            tenda = int.Parse(Console.ReadLine());

            Console.WriteLine("Llistat de productes de tenda: ");
            Console.WriteLine("Selecciona els productes que desitges llistar: ");
            Console.WriteLine("1- Articles");
            Console.WriteLine("2-taulells");
            Console.WriteLine("3-Vernissos");
            opcio = int.Parse(Console.ReadLine());

            Tenda AuxTenda;

            foreach (Tenda t in woodShops.Tenda)
            {
                if (tenda.Equals(BARCELONA)) 
                {
                    AuxTenda = woodShops.GetTendabyPoblacio("Barcelona");
                    AuxTenda.GetproductebyTipus(opcio);
                }
                if (tenda.Equals(GIRONA))
                {
                    AuxTenda = woodShops.GetTendabyPoblacio("Girona");
                    AuxTenda.GetproductebyTipus(opcio);
                }
                if (tenda.Equals(BADALONA))
                {
                    AuxTenda = woodShops.GetTendabyPoblacio("Badalona");
                    AuxTenda.GetproductebyTipus(opcio);
                }

            }
            Console.WriteLine();
        }

        void StockProducte(WoodShops woodShops)
        {
        }

        const int BARCELONA = 1;
        const int GIRONA = 2;
        const int BADALONA= 3;
    }
}


