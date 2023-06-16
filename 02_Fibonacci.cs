namespace Cwiczenia3
{
    internal class Fibonacci
    {
        public Fibonacci()
        {
            int n = Pomocnik.DostanLiczbe<int>("liczba n:", int.MaxValue, int.MinValue);
            ObliczFibonacciego(n);
        }

        Dictionary<int, decimal> FibonacciSkrytka = new Dictionary<int, decimal>();

        public decimal ObliczFibonacciego(int n)
        {
            if(FibonacciSkrytka.TryGetValue(n, out decimal value))
            {
                return value;
            }

            decimal rezultat;
            if(n == 0)
            {
                Console.WriteLine($"N{n} = 0");
                FibonacciSkrytka[n] = 0;
                return 0;
            }

            if(n == 1)
            {
                Console.WriteLine($"N{n} = 1");
                FibonacciSkrytka[n] = 1;
                return 1;
            }

            rezultat = ObliczFibonacciego(n - 2) + ObliczFibonacciego(n - 1);
            FibonacciSkrytka[n] = rezultat;
            Console.WriteLine($"N{n} = {rezultat}");
            return rezultat;
        }
    }
}
