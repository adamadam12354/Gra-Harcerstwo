using System;

namespace gra_harcerstwo
{
    public class KontrolerObozu
    {

        private Oboz _oboz = new Oboz(600, 3, 15, 0 , 0 , 0);
        public int Kara { get; set; } = 0;
        public Oboz PobierzOboz()
        {
            return _oboz;
        }

        public int DodajLosowyPrzychodDlaObozu()
        {
            var losowaLiczba = Helper.LosujLiczbe(1, 4);
            var przychod = _oboz.LiczbaNamiotow * _oboz.LiczbaOsob * losowaLiczba / 2 + _oboz.Menazniki;
            _oboz.Pieniadze += przychod;
            return przychod;
        }

        public int LosujWydatki()
        {
            var losowaLiczba = Helper.LosujLiczbe(0, 10);
            return losowaLiczba * _oboz.LiczbaOsob;
        }

        public int LosujPopolacje(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public void DofinansowanieZUE()
        {
            int NowaLosowa = Helper.LosujLiczbe(0, 20);
            if (NowaLosowa > 17)
            {
                int NowszaLosowa = Helper.LosujLiczbe(10, 350);
                Console.WriteLine("dostaliśmy dofinansowanie z UE: " + NowszaLosowa + " pieniędzy");
                _oboz.Pieniadze += NowszaLosowa;
                _oboz.Zadowolenie++;
            }
        }
        public void SanepidKara()
        {
            int losowaZnowu = Helper.LosujLiczbedwa(0,55);
            if (losowaZnowu <= 30 && losowaZnowu >= 25)
            {

                int losowa = Helper.LosujLiczbe(10, 150);
                Console.WriteLine("sanepid nałożył karę za brak czystości w obozie, w wysokości " + losowa + " pieniędzy");
                _oboz.Pieniadze -= losowa;
                _oboz.Zadowolenie -= 2;
            }
        }
        
        public void Deszcz ()
        {
            int losowaZnowu = Helper.LosujLiczbetrzy(0, 100);
            if (losowaZnowu <= 25)
            {
                Console.WriteLine("dziśiaj padał deszcz i spada zadowolenie");
                _oboz.Zadowolenie -= 2;
            }
        }
        public void Burza()
        {
            int losowat = Helper.LosujLiczbe(0, 140);
            if (losowat >= 25 && losowat <= 40 && _oboz.Menazniki >= 5)
            {
                Console.WriteLine("Dzisiaj burza zaniszczyła 3 menażniki");
                _oboz.Menazniki -= 3;
            }
            if (losowat >= 41 && losowat <= 50 && _oboz.Menazniki >= 3)
            {
                Console.WriteLine("Dzisiaj burza zaniszczyła 2 menażniki");
                _oboz.Menazniki -= 2;
            }
            if (losowat >= 51 && losowat <= 65 && _oboz.Menazniki >= 2)
            {
                Console.WriteLine("Dzisiaj burza zaniszczyła 1 menażnik");
                _oboz.Menazniki -= 1;
            }
            if (losowat >= 15 && losowat <= 24 && _oboz.Menazniki >= 25)
            {
                Console.WriteLine("Dzisiaj burza zaniszczyła 5 menażników");
                _oboz.Menazniki -= 3;
            }
        }

        public void Menele()
        {
            int losowaliczba = Helper.LosujLiczbe(1, 1000);
            if (losowaliczba >= 800 && losowaliczba <= 870)
            {


                Console.WriteLine("dziś wszyscy charcerze chodzili jak menele bo komenda zaniedbała by iść w szeregu , poziom musztry zmniejsza się");
                _oboz.Ogarniecie -= 3;
            }
        }

        public void PoraceSpoleczne ()
        {
            int losowaliczba = Helper.LosujLiczbe(1, 1000);
            int zarobek = Helper.LosujLiczbe(1,500);
            if (losowaliczba >= 100 && losowaliczba <= 115) 
            {
                Console.WriteLine("Pewin gość zaoferował że zapłaci za pomoc jakąś kwote");
                Console.WriteLine("chcesz pomóc?");
                Console.WriteLine("1-tak");
                Console.WriteLine("2-nie");
                int pomoc = Convert.ToInt32(Console.ReadLine());
                switch(pomoc)
                {
                    case 1:
                        Console.WriteLine("zarobiliśmy " + zarobek + " pieniędzy");
                        _oboz.Pieniadze += zarobek;
                        _oboz.Zadowolenie -= 3;
                        _oboz.Ogarniecie++;
                        break;
                }
            }
            if (losowaliczba >= 5 && losowaliczba <= 20)
            {
                Console.WriteLine("Pewin gość zaoferował że zapłaci za pomoc jakąś kwote");
                Console.WriteLine("chcesz pomóc?");
                Console.WriteLine("1-tak");
                Console.WriteLine("2-nie");
                int pomoc = Convert.ToInt32(Console.ReadLine());
                switch (pomoc)
                {
                    case 1:
                        Console.WriteLine("zarobiliśmy " + zarobek + " pieniędzy");
                        _oboz.Pieniadze += zarobek;
                        _oboz.Zadowolenie -= 3;
                        _oboz.Ogarniecie++;
                        break;
                }
            }
            if (losowaliczba >= 220 && losowaliczba <= 230)
            {
                Console.WriteLine("Pewin gość zaoferował że zapłaci za pomoc jakąś kwote");
                Console.WriteLine("chcesz pomóc?");
                Console.WriteLine("1-tak");
                Console.WriteLine("2-nie");
                int pomoc = Convert.ToInt32(Console.ReadLine());
                switch (pomoc)
                {
                    case 1:
                        Console.WriteLine("zarobiliśmy " + zarobek + " pieniędzy");
                        _oboz.Pieniadze += zarobek;
                        _oboz.Zadowolenie -= 3;
                        _oboz.Ogarniecie++;
                        break;
                }
            }
            if (losowaliczba >= 400 && losowaliczba <= 420)
            {
                Console.WriteLine("Pewin gość zaoferował że zapłaci za pomoc jakąś kwote");
                Console.WriteLine("chcesz pomóc?");
                Console.WriteLine("1-tak");
                Console.WriteLine("2-nie");
                int pomoc = Convert.ToInt32(Console.ReadLine());
                switch (pomoc)
                {
                    case 1:
                        Console.WriteLine("zarobiliśmy " + zarobek + " pieniędzy");
                        _oboz.Pieniadze += zarobek;
                        _oboz.Zadowolenie -= 3;
                        _oboz.Ogarniecie++;
                        break;
                }
            }
            if (losowaliczba >= 600 && losowaliczba <= 620)
            {
                Console.WriteLine("Pewin gość zaoferował że zapłaci za pomoc jakąś kwote");
                Console.WriteLine("chcesz pomóc?");
                Console.WriteLine("1-tak");
                Console.WriteLine("2-nie");
                int pomoc = Convert.ToInt32(Console.ReadLine());
                switch (pomoc)
                {
                    case 1:
                        Console.WriteLine("zarobiliśmy " + zarobek + " pieniędzy");
                        _oboz.Pieniadze += zarobek;
                        _oboz.Zadowolenie -= 3;
                        _oboz.Ogarniecie++;
                        break;
                }
            }
            if (losowaliczba >= 800 && losowaliczba <= 815)
            {
                Console.WriteLine("Pewin gość zaoferował że zapłaci za pomoc jakąś kwote");
                Console.WriteLine("chcesz pomóc?");
                Console.WriteLine("1-tak");
                Console.WriteLine("2-nie");
                int pomoc = Convert.ToInt32(Console.ReadLine());
                switch (pomoc)
                {
                    case 1:
                        Console.WriteLine("zarobiliśmy " + zarobek + " pieniędzy");
                        _oboz.Pieniadze += zarobek;
                        _oboz.Zadowolenie -= 3;
                        _oboz.Ogarniecie++;
                        break;
                }
            }
            if (losowaliczba >= 985 && losowaliczba <= 999)
            {
                Console.WriteLine("Pewin gość zaoferował że zapłaci za pomoc jakąś kwote");
                Console.WriteLine("chcesz pomóc?");
                Console.WriteLine("1-tak");
                Console.WriteLine("2-nie");
                int pomoc = Convert.ToInt32(Console.ReadLine());
                switch (pomoc)
                {
                    case 1:
                        Console.WriteLine("zarobiliśmy " + zarobek + " pieniędzy");
                        _oboz.Pieniadze += zarobek;
                        _oboz.Zadowolenie -= 3;
                        _oboz.Ogarniecie++;
                        break;
                }
            }

        }

        public void Przychodludzinakapitule ()
        {
            _oboz.Osobychetnenakapitule++;
        }

        public void Hack ()
        {
            _oboz.Pieniadze += 999999999;
        }

        public void KlasycznyTrybGry ()
        {
            _oboz.Klasyczny = true;
        }
        public void Codzienneodejmowanieogarniecia ()
        {
            _oboz.Ogarniecie--;
        }


        public void SprwadzStanObozu()
        {
            Console.WriteLine("pieniądze " + _oboz.Pieniadze);
            Console.WriteLine("populacja " + _oboz.LiczbaOsob + " harcerzy");
            Console.WriteLine("namioty " + _oboz.LiczbaNamiotow);
            Console.WriteLine("menażniki " + _oboz.Menazniki);
            

            if (_oboz.Obrona.Zariba == 0)
            {
                Console.WriteLine("brak zariby");
            }
            else
            {
                Console.WriteLine("zariba " + _oboz.Obrona.Zariba);
            }

            Console.WriteLine("zadowolenie " + _oboz.Zadowolenie);
            Console.WriteLine("Poziom musztry " + _oboz.Ogarniecie);

        }

        public void WydajPieniadze(int wydatki)
        {
            _oboz.Pieniadze -= wydatki;
        }

        public void PokazSaldoKoncowe(int przychod, int wydatki)
        {
            Console.WriteLine("===============================");
            Console.WriteLine("======Podsumowanie rundy=======");
            Console.WriteLine("Przychód: " + przychod);
            Console.WriteLine("Wydatki: " + wydatki);
            Console.WriteLine("Pieniądze obozu: " + _oboz.Pieniadze);
            Console.WriteLine("===============================\n");
        }
        public bool CzyZlapanoPodchadzaczy()
        {
            var liczba = Helper.LosujLiczbe(0, _oboz.Obrona.SzanseNaZlapaniePodchadzaczy);
            return liczba >= 7 ? true : false;

        }

        public void DodajNagrodeDlaObozu(int wartosc)
        {
            _oboz.Pieniadze += wartosc;

        }
        public void OdejmijPieniadzeObozowi(int ilosOdejmowanychPieniedzy)
        {
            _oboz.Pieniadze -= ilosOdejmowanychPieniedzy;
        }

        public int WyliczKareZaSkradzioneeProporce(int iloscsSkradzionychProporcow)
        {
            Kara = iloscsSkradzionychProporcow * 5;
            return Kara;
        }

        public void DajKareZaBrakProporcow()
        {
            _oboz.Pieniadze -= Kara;
        }

        public void DodajLosowaLiczbeOsob()
        {
            if (_oboz.LiczbaOsob < _oboz.MaxLiczbaLudnosci)
            {
                var noweOsoby = Helper.LosujLiczbe(1, 4);
                _oboz.LiczbaOsob += noweOsoby;
                Console.WriteLine("Na obóz przyjechało " + noweOsoby + " harcerzy");
                _oboz.Ogarniecie -= noweOsoby;
            }
        }
        public void PodchodzenieWrogiegoObozo()
        {
            if(_oboz.TejNocyPodchodzimy == true)
            {
                int losowaLiczbaNowa = Helper.LosujLiczbe(0,10);

                if (losowaLiczbaNowa > 5)
                {
                    Console.WriteLine("Dziś w nocy udało nam się podejść obóz wroga");
                    losowaLiczbaNowa *= 12;
                    Console.WriteLine("Za proporce które skradliśmy dostaliśmy " + losowaLiczbaNowa + " pieniędzy");
                    _oboz.Pieniadze += losowaLiczbaNowa;
                }
                else
                {
                    Console.WriteLine("Dziś w nocy nie udało nam się podejść obóz wroga");
                    losowaLiczbaNowa *= 23;
                    Console.WriteLine("Musieliśmy zpłacić wrogą " + losowaLiczbaNowa +  " pieniędzy");
                    _oboz.Pieniadze -= losowaLiczbaNowa;
                }
                _oboz.TejNocyPodchodzimy = false;
            }
            if (_oboz.Oszczedzanie == true)
            {
                int losowanwm = Helper.LosujLiczbe(10, 120);
                Console.WriteLine("Dziś zaoszczędziliśmy " + losowanwm + "pieniędzy");
                _oboz.Pieniadze += losowanwm;
                _oboz.Oszczedzanie = false;
            }

        }

        internal void UlepszOboz(ref int iloscSkradzionychProporcow, int cenaSkradzionychProporcow)
        {
            Console.WriteLine("1.Namiot: 400");

            if (_oboz.Obrona.Zariba == 0)
            {
                Console.WriteLine("2.Zariba: 100");
            }
            else
            {
                Console.WriteLine("2.Ulepszenie zariby: 100");
            }
            if (_oboz.Maszt == 0)
            {
                Console.WriteLine("3.Maszt: 50");
            }
            else
            {
                Console.WriteLine("3.Ulepszenie masztu: 50");
            }

            Console.WriteLine("4.Menażnik - 20");

            if (_oboz.Brama == false)
            {
                Console.WriteLine("5.Brama - 200");
            }

            if (iloscSkradzionychProporcow > 0)
            {
                Console.WriteLine("6.Odkupienie straconych proporców: " + cenaSkradzionychProporcow);

            }

 
            int zakup = Convert.ToInt32(Console.ReadLine());

            do
            {
                switch (zakup)
                {
                    case 1:
                        _oboz.LiczbaNamiotow++;
                        _oboz.Pieniadze -= 400;
                        Console.WriteLine("Kupiłeś namiot");
                        _oboz.MaxLiczbaLudnosci = _oboz.LiczbaNamiotow * 5;
                        break;
                    case 2:
                        if (_oboz.Obrona.Zariba == 0)
                        {
                            Console.WriteLine("Zbudowałeś zaribe");
                        }
                        else
                        {
                            Console.WriteLine("Ulepszyłeś zaribe");
                        }
                        _oboz.Obrona.Zariba++;
                        _oboz.Pieniadze -= 100;
                        _oboz.Obrona.SansaNaPodchodzenie++;
                        _oboz.Obrona.SzanseNaZlapaniePodchadzaczy += 5;
                        break;
                    case 3:
                        if (_oboz.Maszt == 0)
                        {
                            Console.WriteLine( "zbudowałeś maszt");
                            
                        }
                        else
                        {
                            Console.WriteLine("ulepszyłeś maszt");
                        }
                        _oboz.Pieniadze -= 50;
                        _oboz.Obrona.SzanseNaZlapaniePodchadzaczy+= 2;
                        _oboz.Zadowolenie += 3;
                        break;
                    case 4:
                        Console.WriteLine("Kupiłeś menażnik");
                        _oboz.Pieniadze -= 20;
                        _oboz.Menazniki++;
                        break;
                    case 5:
                        if (_oboz.Brama == false)
                        {
                            Console.WriteLine("Kupiłeś Bramę");
                            _oboz.Pieniadze -= 200;
                            _oboz.Zadowolenie += 3;
                            _oboz.Obrona.SzanseNaZlapaniePodchadzaczy += 10;
                            _oboz.Ogarniecie += 5;
                            _oboz.Brama = true;
                        }

                        break;
                    case 6:
                        Console.WriteLine("odkupiłeś proporce");
                        _oboz.Pieniadze -= cenaSkradzionychProporcow;
                        iloscSkradzionychProporcow = 0;
                        Kara = 0;
                        break;
                }
            } while (zakup != 1 && zakup != 2 && zakup != 3 && zakup != 4 && zakup != 5 && zakup != 6);

        }
        public void WyybierzAkcje()
        {
            Console.WriteLine("1-podchodź wrogi obóz tej nocy");
            Console.WriteLine("2-dzisiejszego dnia oszczędzamy");
            Console.WriteLine("3-zorganizuj grę harcerską");
            Console.WriteLine("4-zorganizuj musztrę - 10");
            Console.WriteLine("5-zorganizuj falę - 300");
            Console.WriteLine("6-zorganizuj manewry - 150");
            Console.WriteLine("7-zrób kuchnie polową - 50");
            if (_oboz.Osobychetnenakapitule >= 5)
            {
                Console.WriteLine("8-kapituła - 15");
            }
            if(_oboz.Osobychetnenaogniskostopnia >= 12)
            {
                Console.WriteLine("9-ognisko stopnia");
            }
            int wybranieAkcji = Convert.ToInt32(Console.ReadLine());
            switch(wybranieAkcji)
            {
                case 1:
                    Console.WriteLine("będziemy podchodzić wrogi obóz tej nocy");
                    _oboz.TejNocyPodchodzimy = true;
                    break;
                case 2:
                    Console.WriteLine("dzisiaj oszczędzamy");
                    _oboz.Zadowolenie -= 3;
                    _oboz.Oszczedzanie = true;
                    break;
                case 3:
                    Console.WriteLine("1.Małą - 20");
                    Console.WriteLine("2.średnią - 35");
                    Console.WriteLine("3.Dużą - 70");
                    Console.WriteLine("4.Ogromną -  200");

                    int wybierzrozmiargry = Convert.ToInt32(Console.ReadLine());
                    switch (wybierzrozmiargry)
                    {
                        case 1:
                            Console.WriteLine("Zorganizowaliśmy małą grę");
                            _oboz.Pieniadze -= 20;
                            _oboz.Zadowolenie++;
                            break;
                        case 2:
                            Console.WriteLine("Zorganizowaliśmy średnią grę");
                            _oboz.Pieniadze -= 35;
                            _oboz.Zadowolenie += 2;
                            break;
                        case 3:
                            Console.WriteLine("Zorganizowaliśmy dużą grę");
                            _oboz.Pieniadze -= 70;
                            _oboz.Zadowolenie += 5;
                            break;
                            
                     
                        case 4:
                            Console.WriteLine("Zorganizowaliśmy ogromną grę");
                            _oboz.Pieniadze -= 200;
                            _oboz.Ogarniecie += 1;
                            _oboz.Zadowolenie += 15;
                            break;
                    }
                    break;
                case 4:
                    Console.WriteLine("Zorganizowaliśmy musztrę");
                    _oboz.Zadowolenie -= 1;
                    _oboz.Pieniadze -= 10;
                    _oboz.Ogarniecie += 1;
                    break;
                case 5:
                    Console.WriteLine("Zorganizowaliśmy falę");
                    _oboz.Zadowolenie += 25;
                    _oboz.Ogarniecie += 1;
                    _oboz.Pieniadze -= 300;
                    break;
                case 6:
                    Console.WriteLine("Zorganizwoaliśmy manewry");
                    _oboz.Pieniadze -= 150;
                    _oboz.Zadowolenie += 3;
                    _oboz.Ogarniecie += 10;
                    break;
                case 7 :
                    int losowaliczba = Helper.LosujLiczbe(3, 80);
                    Console.WriteLine("Zorganizowaliśmy kuchnię polową");
                    Console.WriteLine("Zaoszczędziliśmy w ten sposób " + losowaliczba + " pieniędzy");
                    _oboz.Pieniadze -= 50;
                    _oboz.Pieniadze += losowaliczba;
                    _oboz.Ogarniecie++;
                    break;
                case 8:

                    if(_oboz.Osobychetnenakapitule >= 5)
                    {
                        Console.WriteLine("zorganizowaliśmy kapitułę");
                        _oboz.Pieniadze -= 15;
                        _oboz.Ogarniecie++;
                        _oboz.Osobychetnenaogniskostopnia += _oboz.Osobychetnenakapitule;
                        _oboz.Osobychetnenakapitule = 0;
                    }
                    break;
                case 9:
                    if (_oboz.Osobychetnenaogniskostopnia >= 12)
                    {
                        Console.WriteLine(  "zorganizowaliśmy ognisko stopnia");
                        _oboz.Zadowolenie++;
                        _oboz.Ogarniecie += 4;
                        _oboz.Osobychetnenaogniskostopnia = 0;
                    }
                    break;
            }
        }
    }
}
