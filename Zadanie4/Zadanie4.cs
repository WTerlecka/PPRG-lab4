
int[] artefakty = { 104, 208, 315, 104, 421, 512, 208, 630 };

int identyfikator;
int indeks = -1;
int liczbaWystapien = 0;

while (true)
{
    Console.Write("Podaj identyfikator artefaktu: ");

    if (int.TryParse(Console.ReadLine(), out identyfikator))
    {
        break;
    }

    Console.WriteLine("Błędne dane! Podaj poprawny identyfikator.");
}

for (int i = 0; i < artefakty.Length; i++)
{
    if (artefakty[i] == identyfikator)
    {
        if (indeks == -1)
        {
            indeks = i;
        }

        liczbaWystapien++;
    }
}

if (indeks != -1)
{
    Console.WriteLine("Artefakt znaleziony!");
    Console.WriteLine("Indeks pierwszego wystąpienia: " + indeks);
    Console.WriteLine("Liczba wystąpień: " + liczbaWystapien);
}
else
{
    Console.WriteLine("Nie znaleziono artefaktu o podanym identyfikatorze.");
}
