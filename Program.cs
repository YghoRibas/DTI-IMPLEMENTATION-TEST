using System;
using System.Collections.Generic;

namespace DTI_IMPLEMENTATION_TEST
{
    class Program
    {
        /*
        public static double CalculatePrice(List<PetShop> attributes, DateTime Scheduled)
        {
            double finalPrice;

            //NIVEL DE COMPLEXIDADE T1
                if(Scheduled.DayOfWeek == DayOfWeek.Saturday || Scheduled.DayOfWeek == DayOfWeek.Sunday)
                {
                    for(int i = 0; i < attributes.Count ; i++)
                    {
                        
                    }
                }
                else
                {
                    for(int i = 0; i < attributes.Count; i++)
                    {
                        
                    }
                }

            //NIVEL DE COMPLEXIDADE T2
            
                 for(int i = 0; i < Length; i++)
                {
                    if(Scheduled.DayOfWeek == DayOfWeek.Saturday || Scheduled.DayOfWeek == DayOfWeek.Sunday)
                    {
                            
                    }
                    else
                    {

                    }
                }
            
            return finalPrice;
        }
        */
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = new System.Globalization.CultureInfo("pt-BR");

            int smallCount;
            int bigCount;

            Console.WriteLine("Insira uma data de agendamento.");
            Console.WriteLine("Insira a quantidade de cachorros de pequeno porte.");
            smallCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quantidade de cachorros de grande porte");
            bigCount = int.Parse(Console.ReadLine());

            DateTime scheduled = DateTime.Parse(Console.ReadLine());

            //*********************************************************************************************************

                PetShop VaiRex = new PetShop()
                {
                    petShopName = "Vai Rex",
                    priceSmall =  15.00,
                    priceBig = 50.00,
                    distance = 1700,
                    priceSmallWeekend = 20,
                    priceBigWeekend = 55, 
                    smallCounter = smallCount,
                    bigCounter = bigCount          
                };

            //*********************************************************************************************************

            List<PetShop> PetShops = new List<PetShop>();
            PetShops.Add(VaiRex);
            
               

        }
    }
}
