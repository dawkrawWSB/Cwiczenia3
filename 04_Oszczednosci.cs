namespace Cwiczenia3
{
    internal class Oszczednosci
    {
        public Oszczednosci()
        {
            decimal kwotaPoczatkowa = Pomocnik.DostanLiczbe<decimal>("Kwota początkowa: ", decimal.MaxValue, 1);
            decimal oprocentowanie = Pomocnik.DostanLiczbe<decimal>("Oprocentowanie [%, np 97]: ", decimal.MaxValue, decimal.MinValue);
            int liczbaMiesiecy = Pomocnik.DostanLiczbe<int>("Liczba miesiecy: ", int.MaxValue, 1);
            decimal kwotaNaKoncie = kwotaPoczatkowa * (decimal)Math.Pow(1 + (double)((oprocentowanie / 100) / 12), liczbaMiesiecy);
            decimal zarobki = (kwotaNaKoncie - kwotaPoczatkowa);
            decimal belka = zarobki * 0.19M;
            kwotaNaKoncie -= belka;
            zarobki = (kwotaNaKoncie - kwotaPoczatkowa);
            Console.WriteLine($"Kwota końcowa: {kwotaNaKoncie}, zarobki: {zarobki}, podatek belki: {belka}");
        }
    }
}
