using System;

namespace PackageDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            Package porosia = new Package();
            Console.WriteLine("\nPlotesoni te dhenat e porosise: ");

            //TE DHENAT E DERGUESIT

            Console.WriteLine("\nEmri i derguesit: ");
            porosia.senderName=Console.ReadLine();

            Console.WriteLine("\nAdresa e derguesit: ");
            porosia.senderAddress = Console.ReadLine();

            Console.WriteLine("\nQyteti i derguesit: ");
            porosia.senderCity = Console.ReadLine();

            Console.WriteLine("\nShteti i derguesit: ");
            porosia.senderState = Console.ReadLine();

            Console.WriteLine("\nZip Code i derguesit: ");
            porosia.senderZipCode = Convert.ToInt32(Console.ReadLine());

            //TE DHENAT E MARRESIT

            Console.WriteLine("\nEmri i marresit: ");
            porosia.receiverName = Console.ReadLine();

            Console.WriteLine("\nAdresa e marresit: ");
            porosia.receiverAddress = Console.ReadLine();

            Console.WriteLine("\nQyteti i marresit: ");
            porosia.receiverCity = Console.ReadLine();

            Console.WriteLine("\nShteti i marresit: ");
            porosia.receiverState = Console.ReadLine();

            Console.WriteLine("\nZip Code i marresit: ");
            porosia.receiverZipCode = Convert.ToInt32(Console.ReadLine());

            //TE DHENAT E POSOSISE 
            Console.WriteLine("\nPesha e porosise ne ounces: ");
            decimal pesha=Convert.ToDecimal(Console.ReadLine());
            if (pesha < 10)
            {
                Console.WriteLine("Vlere e palejuar! Provo perseri!");
                Console.WriteLine("Pesha e porosise ne ounces: ");
                pesha = Convert.ToDecimal(Console.ReadLine());
            }
            else
            {
                porosia.weight = pesha;
                porosia.Printimi();
            }
        }
    }
}
