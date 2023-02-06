using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230206_Exercici_Objectes_Woodshop
{
    internal class Aplicacio
    {
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
                    CarregaProductes();
                    break;
                case "2":
                    StockTenda();
                    break;
                case "3":
                    StockProducte();
                    break;
               
                case "0":
                    salir = true;
                    break;
            }
            return salir;
        }



    }
}
