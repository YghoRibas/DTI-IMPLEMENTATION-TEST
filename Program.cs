using System;
using System.Collections.Generic;

namespace DTI_IMPLEMENTATION_TEST
{
    class Program
    {
        
        public static void CalculatePrice(List<PetShop> attributes, DateTime Scheduled)
        {

            //NIVEL DE COMPLEXIDADE T1
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
                    priceSmallWeekend = 20,
                    priceBigWeekend = 55, 
                    smallCounter = smallCount,
                    bigCounter = bigCount,          
                };

            //*********************************************************************************************************

            List<PetShop> PetShops = new List<PetShop>();
            PetShops.Add(VaiRex);
            
            //********************************************************************************************************* 

            CalculatePrice(PetShops, scheduled);

            Console.WriteLine(VaiRex.finalPrice);
        }
    }
}
