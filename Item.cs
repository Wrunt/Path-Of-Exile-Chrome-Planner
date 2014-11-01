using System;

namespace Chroming_Guide
{
    class Item
    {
        private readonly int x = 16;
        public int Sockets { get; set; }
        public int Dex { get; set; }
        public int Str { get; set; }
        public int Int { get; set; }
        public double MinimumPercentage { get; set; }
        public double Chance { get; set; }

        public int DesiredBlue { get; set; }
        public int DesiredGreen { get; set; }
        public int DesiredRed { get; set; }

        public double BlueProbability { get { return (double)(Int + x) / (Dex + Str + Int + (3 * x)); } }
        public double GreenProbability { get { return (double)(Dex + x) / (Dex + Str + Int + (3 * x)); } }
        public double RedProbability { get { return (double)(Str + x) / (Dex + Str + Int + (3 * x)); } }

        public Item(int soc, int dex, int str, int inte, double min = .95)
        {
            Sockets = soc;
            Dex = dex;
            Str = str;
            Int = inte;
            MinimumPercentage = min;
        }

        public void SetDesiredColors(int g, int b, int r)
        {
            DesiredBlue = b;
            DesiredGreen = g;
            DesiredRed = r;
            Chance = ((DesiredBlue * BlueProbability) + (DesiredGreen + GreenProbability) + (DesiredRed + RedProbability)) / Sockets;
        }

        public int GetNumberOfChroms()
        {
            double baseChance = 1 - (Chance / 100);
            
            int tries = 1;

            for (double currentPercent = 0; currentPercent < MinimumPercentage; tries++)
            {
                currentPercent = 1 - Math.Pow(baseChance, tries);
            }

            return tries;
        }
    }
}
