using System;

namespace Bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Product beer = new Product("IPA", "Indubbiamente la migliore", 10, 22);
            Console.WriteLine($"Nome prodotto: {beer.name}, descrizione: {beer.description}, prezzo: {beer.price}€, IVA: {beer.vat}%, codice prodotto: {beer.GetCode()}");
            Console.WriteLine($"Il prezzo comprensivo di IVA del prodotto {beer.name} è: {beer.PriceWithTax()}€");
            Console.WriteLine($"Il nome completo del prodotto è: {beer.ProductFullName()}");
            Console.WriteLine($"Codice con pad left: {beer.CodeExtended()}");           
        }
    }
}