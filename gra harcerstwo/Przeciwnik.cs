using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gra_harcerstwo
{
    public class Przeciwnik
    {
        public int SzansaPodchodzenia { get; set; }
        public int SilaPodchodzenia { get; set; } = 10;

        
        public void LosujSilePochodzenia()
        {
            SzansaPodchodzenia = Helper.LosujLiczbe(0, 10);
        }
        public int LosujSkradzioneProporce(int iloscNamiotow)
        {
            return Helper.LosujLiczbe(1, iloscNamiotow * 2);
        }
        public int WyznaczCeneUkradzionychProporcow (int iloscSkradzionychPropocow)
        {
            var losowaLiczba = Helper.LosujLiczbe(3,20);
            return iloscSkradzionychPropocow * losowaLiczba;
        }
    }
}
