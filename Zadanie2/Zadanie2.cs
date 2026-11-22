Dictionary<string, int> ceny = new Dictionary<string, int>
{
    {"Miecz", 100},
    {"Tarcza", 75},
    {"Mikstura", 20}
};

foreach (KeyValuePair<string, int> para in ceny)
{
    Console.WriteLine($"{para.Key}: {para.Value} sztuk złota");
}

string przedmiot;
while (true)
{
    Console.WriteLine("Podaj nazwę nowego przedmiotu: ");
    przedmiot = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(przedmiot))
    {
        Console.WriteLine("Nazwa nie może być pusta");
        continue;
    }
    if (ceny.ContainsKey(przedmiot))
    {
        Console.WriteLine("Taki przedmiot już istanieje");
        continue;
    }

    break;
}

int cena;
while (true)
{
    Console.WriteLine("Podaj cenę przedmiotu: ");
    if (!int.TryParse(Console.ReadLine(), out cena))
    {
        Console.WriteLine("Błąd, podaj poprawną cenę");
        continue;
    }

    if (cena < 0)
    {
        Console.WriteLine("Błąd, cena nie może być ujemna");
        continue;
    }
    break;
}
ceny.Add(przedmiot, cena);
Console.WriteLine("Przedmiot został dodany");

Console.Write("Podaj nazwę przedmiotu: ");
string nazwa = Console.ReadLine()!;

if (ceny.ContainsKey(nazwa))
{
    Console.WriteLine($"Cena: {ceny[nazwa]} sztuk złota");
}
else
{
    Console.WriteLine("Nie ma takiego przedmiotu.");
}

foreach (KeyValuePair<string, int> para in ceny)
{
    Console.WriteLine($"{para.Key}: {para.Value} sztuk złota");
}