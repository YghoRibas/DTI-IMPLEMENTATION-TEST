using System;
using System.Collections.Generic;
using DTI_IMPLEMENTATION_TEST;

namespace System.Linq
{
    class Program
    {
        
        public static void CalculatePrice(List<PetShop> attributes, DateTime Scheduled)
        {
            if(Scheduled.DayOfWeek == DayOfWeek.Saturday || Scheduled.DayOfWeek == DayOfWeek.Sunday)
            {
                for(int i = 0; i < attributes.Count ; i++)
                {
                    attributes[i].finalPrice = (attributes[i].bigCounter * attributes[i].priceBigWeekend) +
                     (attributes[i].smallCounter * attributes[i].priceSmallWeekend);
                }
            }
            else
            {
                for(int i = 0; i < attributes.Count; i++)
                {
                    attributes[i].finalPrice = (attributes[i].bigCounter * attributes[i].priceBig) +
                     (attributes[i].smallCounter * attributes[i].priceSmall);        
                }
            }
        }
        
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = new System.Globalization.CultureInfo("pt-BR");

            int smallCount;
            int bigCount;  
            
            Console.WriteLine("Insira a quantidade de cachorros de pequeno porte.");
            smallCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quantidade de cachorros de grande porte");
            bigCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira uma data de agendamento.");
            DateTime scheduled = DateTime.Parse(Console.ReadLine());

            //****************************************** LIST *********************************************************

                PetShop VaiRex = new PetShop()
                {
                    petShopName = "Vai Rex",
                    priceSmall =  15.00,
                    priceBig = 50.00,
                    distance = 1700,
                    priceSmallWeekend = 20.00,
                    priceBigWeekend = 55.00, 
                    smallCounter = smallCount,
                    bigCounter = bigCount,          
                };

                PetShop MeuCanino = new PetShop()
                {
                    petShopName = "Meu Canino",
                    priceSmall =  20.00,
                    priceBig = 40.00,
                    distance = 2000,
                    priceSmallWeekend = 20.00 * (1.2),
                    priceBigWeekend = 40.00 * (1.2), 
                    smallCounter = smallCount,
                    bigCounter = bigCount,   
                };

                PetShop ChowChawgs = new PetShop()
                {
                    petShopName = "ChowChawgs",
                    priceSmall =  30.00,
                    priceBig = 45.00,
                    distance = 800,
                    priceSmallWeekend = 30.00,
                    priceBigWeekend = 45.00, 
                    smallCounter = smallCount,
                    bigCounter = bigCount,   
                };

            //*********************************************************************************************************

            List<PetShop> PetShops = new List<PetShop>();
            PetShops.Add(VaiRex);
            PetShops.Add(MeuCanino);
            PetShops.Add(ChowChawgs);
            
            //********************************************************************************************************* 

            CalculatePrice(PetShops, scheduled);

            IEnumerable<PetShop> query = 
            from elements in PetShops
                orderby elements.finalPrice, elements.distance
                select elements;
                 
            Console.WriteLine(query.First().petShopName);
        }
    }
}
