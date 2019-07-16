using System;

namespace FlowerShop
{
    public class SunFlower : Flower, IDescribable, IStemLength
    {
        public double StemLength { get; set; }
        public int PetalCount { get; set; }

        public string Describe ()
        {
            return $"A beautiful Sunflower with {PetalCount} petals";
        }
    }
}