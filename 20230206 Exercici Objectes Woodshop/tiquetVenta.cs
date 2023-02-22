using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _20230206_Exercici_Objectes_Woodshop
{
    internal class TiquetVenta
    {
        public TiquetVenta() {

            arrayLineatiquets = new ArrayList();
        }
        private int numero;
        private DateTime data;
        private ArrayList arrayLineatiquets;
        private Client client;

        public int Numero { get => numero; set => numero = value; }
        public DateTime Data { get => data; set => data = value; }
        public ArrayList ArrayLineatiquets { get { return arrayLineatiquets; } }
        internal Client Client { get => client; set => client = value; }

        public void AddLineatiquet(LineaTiquet lineaTiquet)
        {
            arrayLineatiquets.Add(lineaTiquet);
        }

        public override string ToString()
        {
            return "Client" + client.Nom + "\nN.Tiquet: " + numero + "\nData: " + data + "Detall: " +  "\n" +  ArrayLineatiquets;
        }

        

        
    }
}
