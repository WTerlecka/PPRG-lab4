int[] zlotoWTurach = { 5, 12, 0, 8, 15 };
int suma = 0;
int wIlu10 = 0;

for (int i = 0; i < zlotoWTurach.Length; i++)
{
    Console.WriteLine($"Tura {i + 1}: {zlotoWTurach[i]} sztuk złota");
    suma += zlotoWTurach[i];
    if (zlotoWTurach[i] >= 10)
    {
        wIlu10 += 1;
    }
}

double srednia = (double)suma / zlotoWTurach.Length;

Console.WriteLine($"Łączna suma złota: {suma}");
Console.WriteLine($"Średnia ilość złota na turę: {srednia}");
Console.WriteLine($"Złoto wynisło conajmniej 10 w {wIlu10} turach");
Console.Write("Od tyłu: ");

for (int i = zlotoWTurach.Length - 1; i >=0; i--)
{
    Console.Write($"{zlotoWTurach[i]} ");
}