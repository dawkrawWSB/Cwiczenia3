namespace Cwiczenia3
{
    internal class WzorZSilniami
    {
        public WzorZSilniami()
        {
            int n = Pomocnik.DostanLiczbe<int>("Podaj n:", int.MaxValue, 5);
            int k = Pomocnik.DostanLiczbe<int>("Podaj k:", int.MaxValue, 5);
            int silniaN = ObliczSilnie(n);
            int silniaK = ObliczSilnie(k);
            Console.WriteLine($"Wynik: {(silniaN - silniaK) / (decimal)silniaK}");
        }

        public static int ObliczSilnie(int liczba)
        {
            if(liczba == 0) 
            {
                return 1;
            }
            return ObliczSilnie(liczba - 1) * liczba;
        }
    }
}
