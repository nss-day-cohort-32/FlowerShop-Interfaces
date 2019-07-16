using System.Collections.Generic;

namespace FlowerShop
{
    public class FlowerShop
    {
        public List<Rose> Roses { get; set; }
        public List<Lilly> Lilies { get; set; }
        public List<SunFlower> SunFlowers { get; set; }
        public List<Tulip> Tulips { get; set; }

        // Any flower that goes in the Mothers Day arragement
        // must have a stem length property
        public List<IStemLength> MothersDayArrangement { get; set; } = new List<IStemLength>
        {
            new Rose () { PetalCount = 27, Price = 3.00 },
            new SunFlower () { PetalCount = 50, Price = 5.00 },
        };

        // Any flower in the Birthday arrangement must have
        // a Color property
        public List<IColor> BirthDayArrangement { get; set; } = new List<IColor>
        {
            new Rose () { Color = "Red", Price = 3.00 },
            new Tulip () { Color = "White", Price = 4.00 }
        };

    }
}