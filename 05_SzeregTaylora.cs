namespace Cwiczenia3
{
    internal class SzeregTaylora
    {
        public SzeregTaylora()
        {
            int n = Pomocnik.DostanLiczbe<int>("n: ", int.MaxValue, 1);
            int x = Pomocnik.DostanLiczbe<int>("x: ", int.MaxValue, 1);

            decimal suma = 0;

            for (int i = 0; i < n; i++)
            {
                suma += (decimal)Math.Pow(x, i) / ObliczSilnie(i);
            }

            Console.WriteLine($"Suma: {suma}");
        }

        public static int ObliczSilnie(int liczba)
        {
            if (liczba == 0)
            {
                return 1;
            }
            return ObliczSilnie(liczba - 1) * liczba;
        }
    }
}
