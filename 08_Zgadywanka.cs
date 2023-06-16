namespace Cwiczenia3
{
    internal class Zgadywanka
    {
        public Zgadywanka()
        {
            int przedzialDolny = 1;
            int przedzialGorny = 20;
            int odp = -1;
            
            do
            {
                int guess = Random.Shared.Next(przedzialDolny, przedzialGorny);
                Console.WriteLine($"Czy liczba to {guess}?:");
                odp = Pomocnik.DostanLiczbe<int>("Odpowiedz", -1, 1);
                if(odp == -1)
                {
                    przedzialDolny = guess+1;
                }else if(odp == 1)
                {
                    przedzialGorny = guess - 1;
                }
            } while (odp != 0);
        }
    }
}
