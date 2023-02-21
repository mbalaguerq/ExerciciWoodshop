using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _20230206_Exercici_Objectes_Woodshop
{
    internal class Aplicacio

    {
        const int BARCELONA = 1;
        const int GIRONA = 2;
        const int BADALONA = 3;
        const int DESCOMPTEPRO = 10;

        int nTiquet = 1;
        int nSoci = 4;
        DateTime date = DateTime.Now.Date;

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
            Console.WriteLine("4. Llistat de clients");
            Console.WriteLine("5. Nou Tiquet");
            Console.WriteLine("6. Búsqueda de tiquet");
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

        bool ExecutarMenu
            (String opcio)
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
                case "4":
                    LlistatClients(woodShops);
                    break;
                case "5":
                    NouTiquet(woodShops);
                    break;

                case "0":
                    salir = true;
                    break;
            }
            return salir;
        }
        void CarregaProductes(WoodShops woodShops)
        {
            //Console.WriteLine(date.ToShortDateString());

            //creem els objectes client i els afegim al array clients
            Client client1 = new Client();
            client1.Nif = "11111111A";
            client1.Nom = "Benito Camelas";

            Client client2 = new Client();
            client2.Nif = "22222222B";
            client2.Nom = "Helena Nito Del Bosque";

            Woodfriend woodfriend1 = new Woodfriend();
            woodfriend1.NumSoci = 0000001;
            woodfriend1.Nif = "46712725r";
            woodfriend1.Nom = "Marc Balaguer";

            Woodfriend woodfriend2 = new Woodfriend();
            woodfriend2.NumSoci = 0000002;
            woodfriend2.Nif = "46709705r";
            woodfriend2.Nom = "Eduardo Pardo";

            Woodfriend woodfriend3 = new Woodfriend();
            woodfriend3.NumSoci = 0000003;
            woodfriend3.Nif = "38707707S";
            woodfriend3.Nom = "Joserra Bolargo";

            Professional professional1 = new Professional();
            professional1.Descompte = 15;
            professional1.Nif = "33333333C";
            professional1.Nom = "Carmela Comes";

            Professional professional2 = new Professional();
            professional2.Descompte = 12;
            professional2.Nif = "44444444D";
            professional2.Nom = "Benito Puesto";

            Professional professional3 = new Professional();
            professional3.Descompte = 13;
            professional3.Nif = "55555555E";
            professional3.Nom = "Maria Monja";


            woodShops.AddClient(professional1);
            woodShops.AddClient(professional2);
            woodShops.AddClient(professional3);
            woodShops.AddClient(woodfriend1);
            woodShops.AddClient(woodfriend2);
            woodShops.AddClient(woodfriend3);
            woodShops.AddClient(client1);
            woodShops.AddClient(client2);




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

            Tenda AuxTenda;//creem un objecte al que assignar-li la botiga que ens retorna el mètode

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

            //Dado un código de producto, mostrar el stock de
            //cada una de las tiendas en que exista el producto.
            string codi;
            Console.Write("Codi producte: ");
            codi = Console.ReadLine();

            foreach (Tenda tenda in woodShops.Tenda)
            {
                foreach (Producte pro in tenda.Producte)
                {
                    if (pro.Codi.Equals(codi))
                    {
                        Console.Write(tenda.Poblacio + " ");
                        Console.WriteLine(pro.Stock);
                    }
                }
            }
        }

        void LlistatClients(WoodShops woodShops)
        {
            //Mostrar listado de todos los clientes,
            //indicando el tipo de cliente.

            Console.WriteLine();

            foreach (Client client in woodShops.ArrayClient)
            {
                if (client is Professional)
                {
                    Console.WriteLine("Client Professional");
                    Console.WriteLine(client.ToString() + "\n");
                }
                else if (client is Woodfriend)
                {
                    Console.WriteLine("Client Woodfriend");
                    Console.WriteLine(client.ToString() + "\n");
                }
                else
                {
                    Console.WriteLine(client.ToString() + "\n");
                }
            }
            Console.WriteLine();
        }
        void NouTiquet(WoodShops woodShops)
        {

            //Añadir ticket de venta en la tienda, al añadir el ticket de venta, además se debe mostrar por pantalla
            //el ticket completo, número, fecha, cliente en caso de ser un cliente registrado, todo el detalle del ticket
            //y el total del importe del ticket teniendo en cuenta el posible descuento en caso de cliente profesional.

            Tenda AuxTenda = null;
            Client auxClient = null;
            Producte pro = null;
            TiquetVenta tiquetVenta1 = new TiquetVenta();
            LineaTiquet auxlinea = new LineaTiquet();
            bool stockSuficient = false;

            int tenda, quantitat;
            var randomNumber = new Random().Next(0, 100);
            bool sortir = false;
            string codi, no, nif, si, nom;



            Console.WriteLine("Selecciona la tenda: ");
            Console.WriteLine("1- Barcelona");
            Console.WriteLine("2-Girona");
            Console.WriteLine("3-Badalona");
            tenda = int.Parse(Console.ReadLine());

            foreach (Tenda t in woodShops.Tenda)//busquem tenda
            {
                if (tenda.Equals(BARCELONA))
                {
                    AuxTenda = woodShops.GetTendabyPoblacio("Barcelona");
                }
                if (tenda.Equals(GIRONA))
                {
                    AuxTenda = woodShops.GetTendabyPoblacio("Girona");
                }
                if (tenda.Equals(BADALONA))
                {
                    AuxTenda = woodShops.GetTendabyPoblacio("Badalona");
                }
            }
            do//while per afegir tantes lineas de tiquet com es vulgi
            {
                Console.Write("Afegir article: ");
                codi = Console.ReadLine();
                pro = AuxTenda.GetproductebyCodi(codi);
                Console.WriteLine(pro.Descripcio);
                Console.WriteLine("Stock: " + pro.Stock + " unitats");
                Console.WriteLine("Pvp " + pro.Pvp + " Euros");
                Console.WriteLine();

                do
                {
                    Console.Write("Quantitat: ");
                    quantitat = int.Parse(Console.ReadLine());

                    if (pro.Stock < quantitat)
                    {
                        Console.WriteLine("No hi ha suficient stock de l'article seleccionat");
                        Console.WriteLine("Inserta una quantitat inferior a l'stock actual ");
                    }
                    else
                    {
                        stockSuficient = true;
                    }
                } while (!stockSuficient);

                auxlinea.Quantitat = quantitat;
                auxlinea.Producte = pro;
                auxlinea.Preu = pro.Pvp;
                tiquetVenta1.AddLineatiquet(auxlinea);//afegim linea al tiquet

                Console.Write("Vols afegir un altre article? S/N: ");
                no = Console.ReadLine();
                no.ToLower();
                if (no.Equals("n"))
                {
                    sortir = true;
                }
            } while (!sortir);

            Console.WriteLine("Tiquet nº: " + nTiquet++);
            tiquetVenta1.Numero = nTiquet++;

            Console.WriteLine(date.ToShortDateString());
            tiquetVenta1.Data = date;

            Console.Write("Dni client :");
            nif = Console.ReadLine();
            nif.ToLower();
            auxClient = woodShops.GetClientByNif(nif);

            if (auxClient == null)
            {
                int var;

                do
                {
                    Console.WriteLine("Nou Client");
                    Console.WriteLine("Seleccioni una opció: ");
                    Console.WriteLine("1. Nou Client Professional");
                    Console.WriteLine("2. Nou Client Woodfriend");
                    Console.WriteLine("3. No sóc professional i no vull avantatges Woodfriend");
                    var = int.Parse(Console.ReadLine());


                    switch (var)
                    {
                        case 1:
                            Console.WriteLine();
                            Console.WriteLine("1. Nou Client Professional");
                            Console.Write("Introdueixi el Nom i Cognoms: ");
                            nom = Console.ReadLine();

                            Professional auxpro = new Professional();
                            auxpro.Nif = nif;
                            auxpro.Nom = nom;
                            auxpro.Descompte = DESCOMPTEPRO;
                            woodShops.AddClient(auxpro);

                            break;
                        case 2:
                            Console.WriteLine();
                            Console.WriteLine("2. Nou Client Woodfriend");
                            Console.Write("Introdueixi el Nom i Cognoms: ");
                            nom = Console.ReadLine();
                            Console.WriteLine("Número de soci: " + nSoci++);

                            Woodfriend auxWoodFriend = new Woodfriend();
                            auxWoodFriend.Nif = nif;
                            auxWoodFriend.Nom = nom;
                            auxWoodFriend.NumSoci = nSoci++;
                            woodShops.AddClient(auxWoodFriend);

                            break;
                        case 3:
                            Console.WriteLine();
                            Console.WriteLine("3. Nou client: ");
                            Console.Write("Introdueixi el Nom i Cognoms: ");
                            nom = Console.ReadLine();

                            auxClient = new Client();
                            auxClient.Nif = nif;
                            auxClient.Nom = nom;
                            woodShops.AddClient(auxClient);
                            break;
                        case 0:
                            Console.WriteLine("Program Exit  ");
                            break;
                        default:
                            Console.WriteLine("Opción incorrecta");
                            break;
                    }
                } while (var != 0);
                Console.WriteLine("Nou client creat satisfactòriament");
                


                //Comencem a mostrar tiquet per consola
                Console.WriteLine();
                //Dades Tenda
                Console.WriteLine(AuxTenda.Poblacio);
                Console.WriteLine(AuxTenda.Direccio);
                Console.WriteLine();

                //Dades client
            }
            else
            {
                if (auxClient.Nif.Equals(nif))
                {
                    if (auxClient is Woodfriend)
                    {
                        Console.WriteLine("Sr/Sra: " + auxClient.Nom);
                        Console.WriteLine("Soci num: " + (auxClient as Woodfriend).NumSoci);//casting
                    }
                    else if (auxClient is Professional)
                    {
                        Console.WriteLine("Sr/Sra: " + auxClient.Nom);
                        Console.WriteLine("Dcte. Professional: " + (auxClient as Professional).Descompte);
                    }
                    else
                    {
                        Console.WriteLine("Sr/Sra: " + auxClient.Nom);
                    }
                    //Dades Tiquet i detall tiquet
                    Console.WriteLine();
                    Console.WriteLine("Número de tiquet :" + tiquetVenta1.Numero);
                    Console.WriteLine("Data: " + date.ToShortDateString());
                    Console.WriteLine();
                    Console.WriteLine("Detall de productes: ");
                    Console.WriteLine();
                    Console.WriteLine("Producte: " + auxlinea.Producte);
                    Console.WriteLine("Quantitat: " + auxlinea.Quantitat);

                    //Sumatori preu final
                    int val1 = auxlinea.Quantitat;
                    float val2 = (float)val1;
                    float pvpTotal = (auxlinea.Preu * val1);
                    float dtePro = 0;
                    float pvpFinal = pvpTotal;

                    if (auxClient is Professional)
                    {
                        dtePro = (auxClient as Professional).Descompte;
                        pvpFinal = (dtePro * 100) / pvpTotal;
                        Console.WriteLine("Pvp total :" + pvpTotal);
                        Console.WriteLine("Descompte Pro:" + dtePro);
                        Console.WriteLine("Pvp final: " + pvpFinal);
                        Console.WriteLine();

                    }
                    else
                    {
                        Console.WriteLine("Pvp total :" + pvpTotal);
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                }
            }

        }

    }
}

