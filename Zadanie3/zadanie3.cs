List<string> plecak = new List<string>
{
    "Miecz",
    "Mikstura",
    "Mapa"
};
Console.WriteLine("zawartość plecaka: ");

foreach( string przedmiot in plecak)
{
    Console.WriteLine($"{przedmiot}, ");
}

Console.WriteLine("Liczba przedmiotów: " + plecak.Count);

string nowyPrzedmiot;

while (true)
{
    Console.WriteLine("Podaj nazwę nowego przedmiotu: ");
    nowyPrzedmiot = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(nowyPrzedmiot))
    {
        Console.WriteLine("Nazwa nie może być pusta");
        continue;
    }
    break;
}

plecak.Add(nowyPrzedmiot);

Console.WriteLine("Dodano przedmiot");

string przedmiotDoUsuniecia;
while (true)
{
    Console.WriteLine("Podaj nazwę przedmiotu do usunięcia: ");
    przedmiotDoUsuniecia = Console.ReadLine();

    if(string.IsNullOrWhiteSpace(przedmiotDoUsuniecia))
    {
        Console.WriteLine("Nazwa nie może być pusta");
        continue;
    }
    break;
}

bool usunieto = plecak.Remove(przedmiotDoUsuniecia);
if (usunieto)
{
    Console.WriteLine("Przedmiot został usunięty");
}
else
{
    Console.WriteLine("Nie znaleziono takiego przedmiotu");
}

Console.WriteLine("Aktualna zawartośc plecaka: ");
foreach( string przedmiot in plecak)
{
    Console.WriteLine($"{przedmiot}, ");
}

Console.WriteLine("Liczba przedmiotów: " + plecak.Count);