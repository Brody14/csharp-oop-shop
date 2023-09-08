using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{

    /*creare la classe Prodotto che gestisce i prodotti di uno shop. Un prodotto è caratterizzato da:
           codice(numero intero)
           nome
           descrizione
           prezzo
           iva
    Usate opportunamente i livelli di accesso (public, private), i costruttori, i metodi getter e setter ed eventuali altri metodi di 
    “utilità” per fare in modo che:
    alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
    Il codice prodotto sia accessibile solo in lettura
    Gli altri attributi siano accessibili sia in lettura che in scrittura
  */
    public class Product
    {
        //ATTRIBUTI
        private int code;
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public int vat { get; set; }

        //COSTRUTTORE
        public Product(string name, string description, double price, int vat)
        {
            SetCode();
            this.name = name;
            this.description = description;
            this.price = price;
            this.vat = vat;
        }

        //GETTER

        public int GetCode()
        {
            return code;
        }

        //SETTER
        private void SetCode()
        {
            Random rnd = new Random();
            this.code = rnd.Next(1,500);
           
        }

        //METODI
        /*Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
         */

        public double PriceWithTax()
        {
            return price + (price * vat) / 100;
        }

        /*Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome*/

        public string ProductFullName()
        {
            return $"{code} {name}";
        }

       
    }
}
