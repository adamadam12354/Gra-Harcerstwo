using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gra_harcerstwo
{
    public static class Helper
    {
        public static int LosujLiczbe(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public static int LosujLiczbedwa (int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public static int LosujLiczbetrzy(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
