int[] artefakty = { 104, 208, 315, 421, 512, 630, 745, 890, 950 };

int szukany;
while (true)
{
    Console.Write("Podaj identyfikator artefaktu: ");

    if (int.TryParse(Console.ReadLine(), out szukany))
    {
        break;
    }

    Console.WriteLine("Błędne dane! Podaj poprawny identyfikator.");
}

int lewy = 0;
int prawy = artefakty.Length - 1;

int indeks = -1; 

while(lewy <= prawy)
{
    int srodek = (lewy + prawy) / 2;

    if (artefakty[srodek] == szukany)
    {
        indeks = srodek;
        break;
    }
    else if (artefakty[srodek] < szukany)
    {
        lewy = srodek + 1;
    }
    else
    {
        prawy = srodek - 1;
    }
}

if (indeks != -1 )
{
    Console.WriteLine($"Artefakt został znaleziony na indeksie: {indeks}");
}
else
{
    Console.WriteLine("Nie znaleziono artefaktu"); 
}
