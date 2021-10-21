using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageDelivery
{
    
    class Package
    {
        public decimal weight { get; set; } //in ounces

        public decimal costPerOunces { get; set; }
        public string senderName { get; set; }
        public string senderAddress { get; set; }
        public string senderCity { get; set; }
        public string senderState { get; set; }
        public int senderZipCode { get; set; }

        public string receiverName { get; set; }
        public string receiverAddress { get; set; }
        public string receiverCity { get; set; }
        public string receiverState { get; set; }
        public int receiverZipCode { get; set; }
        public Package()
        {
            weight = 0;
            costPerOunces = 10;

            senderName = null;
            senderAddress = null;
            senderCity = null;
            senderState = null;
            senderZipCode = 0;

            receiverName = null;
            receiverAddress = null;
            receiverCity = null;
            receiverState = null;
            receiverZipCode = 0;
            
        }

        public virtual decimal calculateCost()
        {
            decimal cost = costPerOunces * weight;
            return cost;
        }

        public void Printimi()
        {
            decimal cost = 0;
            try
            {   
                int time = kohezgjatja();

                if (time == 1)
                {
                    Console.WriteLine("Vendosni vleren e kostos shtese: ");
                    decimal flatFee = Convert.ToDecimal(Console.ReadLine());
                    if (flatFee < 0)
                    {
                        Console.WriteLine("Vlere e palejuar! Provoni perseri!");
                        time = kohezgjatja();
                    }
                    else
                    {
                        Package kosto = new TwoDayPackage(flatFee);
                        cost = kosto.calculateCost();
                    }

                }
                else if (time == 2)
                {
                    Package kosto = new OvernightPackage();
                    cost = kosto.calculateCost();
                }
                else
                {
                    Console.WriteLine("Vlere e palejuar! Provoni perseri!");
                    kohezgjatja();
                }
            }

            catch (Exception)
            {
                Console.WriteLine("Vlere e palejuar!");
            }
            Console.WriteLine("Te dhenat e porosise jane: ");
            Console.WriteLine("\nEmri i derguesit: " + senderName);
            Console.WriteLine("\nAdresa e derguesit: " + senderAddress);
            Console.WriteLine("\nQyteti i derguesit: " + senderCity);
            Console.WriteLine("\nShteti i derguesit: " + senderState);
            Console.WriteLine("\nZip Code i derguesit: " + senderZipCode);

            Console.WriteLine("\n");

            Console.WriteLine("\nEmri i marresit: " + receiverName);
            Console.WriteLine("\nAdresa e marresit: " + receiverAddress);
            Console.WriteLine("\nQyteti i marresit: " + receiverCity);
            Console.WriteLine("\nShteti i marresit: " + receiverState);
            Console.WriteLine("\nZip Code i marresit: " + receiverZipCode);

            Console.WriteLine("\n");

            Console.WriteLine("Kosto e transportit per porosine eshte: "+cost);
        }



        public int kohezgjatja()
        {
            Console.WriteLine("Koha e arritjes se porosise: ");
            Console.WriteLine("Shtypni 1 per Two Day Package ");
            Console.WriteLine("Shtypni 2 per Overnight Package ");
            int koha = Convert.ToInt32(Console.ReadLine());

            return koha;
        }
    }

}