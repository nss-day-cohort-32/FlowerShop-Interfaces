using System;

namespace FlowerShop
{
    public class Tulip : Flower, IDescribable, IStemLength, IColor
    {
        public string Color { get; set; }
        public double StemLength { get; set; }

        public string Describe ()
        {
            return $"A beautiful {Color} Tulip";
        }
    }
}