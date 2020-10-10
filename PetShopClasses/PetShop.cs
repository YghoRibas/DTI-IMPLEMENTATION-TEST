using System;

namespace DTI_IMPLEMENTATION_TEST
{
    class PetShop : IComparable<PetShop>
    {
        public string petShopName { get; set; }
        public double priceSmall { get; set; }
        public double priceBig { get; set; }
        public double priceSmallWeekend { get; set; }
        public double priceBigWeekend { get; set; }
        public int distance { get; set; }    
        public int smallCounter { get; set; }
        public int bigCounter { get; set; } 
        public double finalPrice { get; set; } 

       
        public int CompareTo(PetShop e)
        {
            return this.finalPrice.CompareTo(e.finalPrice);
        }
        
    }

}