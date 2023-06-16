namespace Cwiczenia3
{
    internal class Pary
    {
        public Pary()
        {
            int liczba = Pomocnik.DostanLiczbe<int>("Liczba: ", int.MaxValue, 1);
            for (int i = 1, y = liczba-1; i <= liczba/2; i++, y--)
            {
                Console.WriteLine($"{i} + {y} = {liczba}");
            }
        }
    }
}
