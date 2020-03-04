using System;

namespace Planner
{
    public class Building
    {

        private string Designer { get; set; }
        
        private DateTime DateConstructed { get; set; }

        private string Address { get; set; }

        private string Owner { get; set; }

        public int Stories { get; set; }

        public double Width { get; set; }

        public double Depth { get; set; }

        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }
        public Building(string addressParam)
        {
            Address = addressParam;
        }
    }


    class Program
    {
        static void Main()
        {
            Building giveAddress = new Building("give it an address")
            {
                Stories = 1,
                Width = 1,
                Depth = 1
            };
        }
    }
}
