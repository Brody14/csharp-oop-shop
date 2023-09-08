using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus
{
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
            this.code = rnd.Next(1, 500);

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

        /*create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri (ad esempio codice 91 diventa 
         * 00000091, mentre codice 12344556 resta come è)*/
        public string CodeExtended()
        {
            string codeString = code.ToString();

            for (int i = codeString.Length; i < 8; i++)
            {
                codeString = 0 + codeString;
            }

            return codeString;
        }

        
        }

}



