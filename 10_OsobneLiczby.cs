namespace Cwiczenia3
{
    internal class OsobneLiczby
    {
        public OsobneLiczby()
        {
            int liczba = Pomocnik.DostanLiczbe<int>("Liczba : ", int.MaxValue, 100);
            List<int> lista = new List<int>();
            do
            {
                lista.Add(liczba % 10);
                liczba /= 10;
            } while (liczba != 0);

            for(int i = lista.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(lista[i]);
            }
        }
    }
}
