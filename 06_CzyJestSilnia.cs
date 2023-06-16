namespace Cwiczenia3
{
    internal class CzyJestSilnia
    {
        public CzyJestSilnia()
        {
            int n = Pomocnik.DostanLiczbe<int>("n: ", int.MaxValue, 1);
            int x = Pomocnik.DostanLiczbe<int>("x: ", int.MaxValue, 1);

            if(x == ObliczSilnie(n))
            {
                Console.WriteLine($"{n} jest.");
            }
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
