using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gra_harcerstwo
{
    public class KontrolerGry
    {
        private static KontrolerGry _obiekt;
        public int Dzien { get; set; } = 1;
        private bool Gameover { get; set; } = false;
        private int IloscSkradzionychProporcow;
        private int CenaUkradzionychProporcow { get; set; }
        private KontrolerGry() { }


        public static KontrolerGry utworzObiekt()
        {
            if (_obiekt == null)
            {
                _obiekt = new KontrolerGry();
            }

            return _obiekt;
        }

        public void WypiszTytulGry()
        {
            Console.WriteLine("====================================================================");
            Console.WriteLine("Witaj w grze Obóz Harcerski ");
            Console.WriteLine("grę stworzył Adam Ginalski");
            Console.WriteLine("gra polega na rozbódowaniu swojego obozu najbardziej jak się da");
            Console.WriteLine("===================================================================\n");

        
            
        }

        public void WybierzTryb(KontrolerObozu kontrolerObozu)
        {
            Console.WriteLine("Wybierz tryb gry");
            Console.WriteLine("1-Klasyczny");
            Console.WriteLine("2-Sandbox");
            Console.WriteLine("3-Sandbox z nieskończonymi pieniędzmi");
            int trybgry = Convert.ToInt32(Console.ReadLine());
            switch (trybgry)
            {
                case 1:
                    Console.WriteLine("Wybrałeś klasyczny tryb gry");
                    kontrolerObozu.KlasycznyTrybGry();

                  break;
                case 2:
                   Console.WriteLine("Wybrałeś Sandbox");
                  break;
                case 3:
                   Console.WriteLine("Wybrałeś Sandbox z nieskończonymi pieniędzmi");
                   kontrolerObozu.Hack();
                  break;

            }

        }

  
        private void WypiszStanObozuIDozwoloneAkcje(KontrolerObozu kontrolerObozu)
        {
            Console.WriteLine("*******************************");
            Console.WriteLine("Dzień: " + Dzien);
            kontrolerObozu.SprwadzStanObozu();
            Console.WriteLine("1-Następna runda");
            Console.WriteLine("2-ulepsznie obozu");
            Console.WriteLine("3-akcje");
        }

        private void WykonajAkcjeRundy(KontrolerObozu kontrolerObozu)
        {
            kontrolerObozu.Przychodludzinakapitule();
            kontrolerObozu.Codzienneodejmowanieogarniecia();
            Dzien++;
            var przychod = kontrolerObozu.DodajLosowyPrzychodDlaObozu();
            var wydatki = kontrolerObozu.LosujWydatki();
            kontrolerObozu.WydajPieniadze(wydatki);
            var oboz = kontrolerObozu.PobierzOboz();
            kontrolerObozu.PodchodzenieWrogiegoObozo();
            kontrolerObozu.DofinansowanieZUE();
            kontrolerObozu.SanepidKara();
            kontrolerObozu.Deszcz();
            kontrolerObozu.Burza();
            kontrolerObozu.Menele();
            kontrolerObozu.PoraceSpoleczne();



            if (Dzien == 32 && oboz.Klasyczny == true)
            {

                Console.WriteLine("        █▓  ");
                Console.WriteLine("       ██▓▓");
                Console.WriteLine("      ███▓▓▓");
                Console.WriteLine("     ████▓▓▓▓");
                Console.WriteLine("    █████▓▓▓▓▓");
                Console.WriteLine("   ██   █▓   ▓▓");
                Console.WriteLine("  ███████▓▓▓▓▓▓▓");
                Console.WriteLine("  ███   █▓   ▓▓▓");
                Console.WriteLine("  ███████▓▓▓▓▓▓▓");
                Console.WriteLine(" ████   █▓   ▓▓▓▓");
                Console.WriteLine(" ████████▓▓▓▓▓▓▓▓");
                Console.WriteLine(" ▓▓▓▓▓▓▓▓████████");
                Console.WriteLine(" ▓▓▓▓   ▓█   ████");
                Console.WriteLine("  ▓▓▓▓▓▓▓███████");
                Console.WriteLine("  ▓▓▓   ▓█   ███");
                Console.WriteLine("  ▓▓▓▓▓▓▓███████");
                Console.WriteLine("   ▓▓   ▓█   ██");
                Console.WriteLine("    ▓▓▓▓▓█████");
                Console.WriteLine("     ▓▓▓▓████");
                Console.WriteLine("      ▓▓▓███");
                Console.WriteLine("       ▓▓██");
                Console.WriteLine("        ▓█");
                Console.WriteLine(" ");
                Console.WriteLine("Gratulację przeszedłeś grę !!!");
                int punkty = oboz.Pieniadze + (oboz.LiczbaNamiotow * 50) + oboz.LiczbaOsob + (oboz.Menazniki * 5) + (oboz.Obrona.Zariba * 20) + (oboz.Ogarniecie * 20) + (oboz.Zadowolenie * 20);
                Console.WriteLine("twój wynik to: " + punkty + " punktów");
                do
                {
                    Console.ReadKey();
                }
                while (Dzien >=1);
                return;
            }
            if (oboz.Pieniadze < 0)
            {

                kontrolerObozu.PokazSaldoKoncowe(przychod,wydatki);
                Console.WriteLine("Zbankrutowałeś");
                Console.WriteLine("Game over");
                Gameover = true;
                Console.ReadKey();
                return;
            }

            var przeciwnik = new Przeciwnik();
            przeciwnik.LosujSilePochodzenia();

            if (przeciwnik.SzansaPodchodzenia <= 2)
            {
                var czyZlapanoPodchadzaczy = kontrolerObozu.CzyZlapanoPodchadzaczy();

                if (czyZlapanoPodchadzaczy)
                {
                    Console.WriteLine("dziś w nocy podchodzono nasz obóz naszczęście udało nam się złapać wroga");
                    Console.WriteLine("dostajemy 100 pieniędzy za odsprzedanie złapanych harcerzy");
                    kontrolerObozu.DodajNagrodeDlaObozu(100);
                }
                else
                {
                    Console.WriteLine("dziś w nocy podchodzono nasz obóz niestety nie udało nam się złapać wroga");
                    IloscSkradzionychProporcow = przeciwnik.LosujSkradzioneProporce(oboz.LiczbaNamiotow);
                    Console.WriteLine("skradziono nam " + IloscSkradzionychProporcow + " proporców");

                    CenaUkradzionychProporcow = przeciwnik.WyznaczCeneUkradzionychProporcow(IloscSkradzionychProporcow);
                    var karaZaNiekupioneProporce = kontrolerObozu.WyliczKareZaSkradzioneeProporce(IloscSkradzionychProporcow);

                    Console.WriteLine("możemy je odkupic za " + CenaUkradzionychProporcow);
                    Console.WriteLine("Jeśli ich nie odkupimy będziemy tracić codzienie " + karaZaNiekupioneProporce);
                    Console.WriteLine("1-odkup");
                    Console.WriteLine("2-niedokupuj");
                    int czyOdkupicProporce; 
                    do
                    {
                        czyOdkupicProporce = Convert.ToInt32(Console.ReadLine());
                    } while (czyOdkupicProporce != 1 && czyOdkupicProporce != 2);
                  

                    switch (czyOdkupicProporce)
                    {
                        case 1:
                            Console.WriteLine("odkupiliśmy proporce za " + CenaUkradzionychProporcow);
                            kontrolerObozu.OdejmijPieniadzeObozowi(CenaUkradzionychProporcow);
                            kontrolerObozu.Kara = 0;
                            IloscSkradzionychProporcow = 0;
                            Console.WriteLine("Dzień: " + Dzien);
                            break;
                        case 2:
                            Console.WriteLine("nieodkupiliśmy proporców");
                            kontrolerObozu.DajKareZaBrakProporcow();
                            break;
                    }

                }
            }

            kontrolerObozu.DodajLosowaLiczbeOsob();
            kontrolerObozu.PokazSaldoKoncowe(przychod,wydatki);

            if (kontrolerObozu.Kara > 0 )
            {
                Console.WriteLine("Z powodu braku posiadania proporców tracimy dodatkowo " + kontrolerObozu.Kara) ;
                kontrolerObozu.OdejmijPieniadzeObozowi(kontrolerObozu.Kara);
            }
        }
        private void UlepszOboz(KontrolerObozu kontrolerObozu)
        {
            kontrolerObozu.UlepszOboz(ref IloscSkradzionychProporcow, CenaUkradzionychProporcow);
        }
        private void WykonajAkcje (KontrolerObozu kontrolerObozu)
        {
            kontrolerObozu.WyybierzAkcje();
        }


        private void ZrobAkcje(int wybor,KontrolerObozu kontrolerObozu)
        {

            switch (wybor)
            {
                case 1:
                    Console.WriteLine("===============================");
                    WykonajAkcjeRundy(kontrolerObozu);
                    break;

                case 2:
                    UlepszOboz(kontrolerObozu);
                    break;
                case 3:
                    WykonajAkcje(kontrolerObozu);
                    break;

            }
        }
    

        public void RozpocznijGre(KontrolerObozu kontrolerObozu)
        {
            WypiszStanObozuIDozwoloneAkcje(kontrolerObozu);

            while (!Gameover)
            {
                int wybor;
                do
                {
                    wybor = Convert.ToInt32(Console.ReadLine());

                } while (wybor != 1 && wybor != 2 && wybor != 3); 
                ZrobAkcje(wybor, kontrolerObozu);
                WypiszStanObozuIDozwoloneAkcje(kontrolerObozu);
            }
        }
    }

}

