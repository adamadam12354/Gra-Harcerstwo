namespace gra_harcerstwo
{
    public class Oboz
    {
        public int Pieniadze { get; set; }
        public int LiczbaProporcow { get; set; }
        public int LiczbaNamiotow { get; set; }
        public int LiczbaOsob { get; set; }
        public int MaxLiczbaLudnosci { get; set; }
        public bool TejNocyPodchodzimy { get; set; } = false;
        public int Zadowolenie { get; set; }
        public int Maszt { get; set; }
        public bool Oszczedzanie { get; set; } = false;
        public int Menazniki { get; set; }
        public bool Klasyczny { get; set; } = false;
        public int  Ogarniecie { get; set; }
        public bool Brama { get; set; } = false;
        public int Osobychetnenakapitule { get; set; }
        public int Osobychetnenaogniskostopnia { get; set; }

        public Obrona Obrona = new Obrona();

        public Oboz(int pieniadze,int liczbaNamiotow,int liczbaOsob,int zadowolenie,int menazniki,int ogarniecie)
        {
            Pieniadze = pieniadze;
            Zadowolenie = zadowolenie;
            Menazniki = menazniki;
            LiczbaNamiotow = liczbaNamiotow;
            LiczbaProporcow = liczbaNamiotow;
            LiczbaOsob = liczbaOsob;
            Ogarniecie = ogarniecie;
            MaxLiczbaLudnosci = liczbaNamiotow * 5;
        }

    }
}
