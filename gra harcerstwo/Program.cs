namespace gra_harcerstwo
{
    class Program
    {
        static void Main(string[] args)
        {
            KontrolerObozu KontrolerObozu = new KontrolerObozu();
            KontrolerGry KontrolerGry = KontrolerGry.utworzObiekt();
            KontrolerGry.WypiszTytulGry();
            KontrolerGry.WybierzTryb(KontrolerObozu);
            KontrolerGry.RozpocznijGre(KontrolerObozu);
        }
    }
}
