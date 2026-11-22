
int[,] mapa = {

    { 5,  0, 12,  3 },

    { 8, 15,  2,  0 },

    { 4,  7, 20,  6 }

};

int wiersze = mapa.GetLength(0);
int kolumny = mapa.GetLength(1);

int sumaZlota = 0;
int maksimum = mapa[0, 0];
int maxWiersz = 0;
int maxKolumna = 0;

Console.WriteLine("Mapa:");

for (int i = 0; i < wiersze; i++)
{
    for (int j = 0; j < kolumny; j++)
    {
        Console.Write(mapa[i, j] + "\t");

        sumaZlota += mapa[i, j];

        if (mapa[i, j] > maksimum)
        {
            maksimum = mapa[i, j];
            maxWiersz = i;
            maxKolumna = j;
        }
    }

    Console.WriteLine();
}

Console.WriteLine("\nLiczba wierszy: " + wiersze);
Console.WriteLine("Liczba kolumn: " + kolumny);
Console.WriteLine("Łączna ilość złota: " + sumaZlota);
Console.WriteLine("Największa wartość: " + maksimum);
Console.WriteLine("Pozycja największej wartości:");
Console.WriteLine("Wiersz: " + maxWiersz);
Console.WriteLine("Kolumna: " + maxKolumna);
