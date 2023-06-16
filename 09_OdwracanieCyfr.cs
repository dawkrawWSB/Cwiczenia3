namespace Cwiczenia3
{
    internal class OdwracanieCyfr
    {
        public OdwracanieCyfr()
        {
            int liczba = Pomocnik.DostanLiczbe<int>("Liczba: ", int.MaxValue, 1);
            int odwrocona = 0;
            do
            {
                odwrocona = odwrocona * 10 + liczba % 10;
                liczba /= 10;
            }while(liczba !=0);
            Console.WriteLine($"Odwrocona Liczba: {odwrocona}");
        }
    }
}
