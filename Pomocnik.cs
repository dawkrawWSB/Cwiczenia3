using System.Numerics;

namespace Cwiczenia3
{
    internal class Pomocnik
    {
        public static T DostanLiczbe<T>(string tekst, T limitGorny, T limitDolny) where T : INumber<T>, IMinMaxValue<T>
        {
            T result;
            string? input;
            do
            {
                Console.WriteLine(tekst);
                input = Console.ReadLine();
            } while (!T.TryParse(input, null, out result) || (result >= limitGorny || result <= limitDolny));
            return result;
        }
    }
}
