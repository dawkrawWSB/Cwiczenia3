using Cwiczenia3;

List<Type> zadania = new List<Type> { typeof(Potegowanie), typeof(Fibonacci), typeof(WzorZSilniami), typeof(Oszczednosci), typeof(SzeregTaylora), typeof(CzyJestSilnia), typeof(Pary),
    typeof(Zgadywanka), typeof(OdwracanieCyfr), typeof(OsobneLiczby)};

Type? zadanieWybrane = null;
do
{
    Console.WriteLine("Wybierz zadanie wpisujac numer i klikajac enter:");
    foreach (Type zadanie in zadania)
    {
        Console.WriteLine($"{zadania.IndexOf(zadanie)} - {zadanie.Name}");
    }
    string? input = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(input) && int.TryParse(input, out int result))
    {
        zadanieWybrane = zadania.ElementAtOrDefault(result);
    }
} while (zadanieWybrane == null);

Activator.CreateInstance(zadanieWybrane);

