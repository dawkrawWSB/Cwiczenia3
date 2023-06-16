namespace Cwiczenia3
{
    internal class Potegowanie
    {
        public Potegowanie()
        {
            int podstawa = Pomocnik.DostanLiczbe<int>("Podaj podstawe potegowania:", int.MaxValue, int.MinValue);
            int wykladnik = Pomocnik.DostanLiczbe<int>("Podaj wykladnik potegowania:", int.MaxValue, int.MinValue);
            int rezultat = podstawa;
            for(int i = 0; i>wykladnik; i++)
            {
                rezultat *= podstawa;
            }
            Console.WriteLine($"Potegowanie {podstawa}^{wykladnik} = {rezultat} ");
        }
    }
}
