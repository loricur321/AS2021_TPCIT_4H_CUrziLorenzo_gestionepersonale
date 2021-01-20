using AS2021_TPCIT_4H_CUrziLorenzo_gestionepersonale.Models;
using System;

namespace AS2021_TPCIT_4H_CUrziLorenzo_gestionepersonale
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gestione dipendenti di Lorenzo Curzi, 4H");

            //creo un nuovo dipendente
            Dipendente d1 = new Dipendente("Rossi", "Mario", "RMA", "333", "Milano", "Saldatore");

            //visualizzo le sue informazioni
            Console.WriteLine(d1.VisualizzaDati());
            Console.WriteLine("----------------------------------------------------");

            //Modifico le sue informazioni
            d1.ModificaDati("Rossi", "Gianluca", "GMA", "340", "Roma", "Venditore");

            //visualizzo le informazioni aggiornate
            Console.WriteLine(d1.VisualizzaDati());
            Console.WriteLine("----------------------------------------------------");

            //cancello le informazioni del dipendente
            d1.CancellaDati();

            //visualizzo le informazioni aggiornate
            Console.WriteLine(d1.VisualizzaDati());
            Console.WriteLine("----------------------------------------------------");
        }
    }
}
