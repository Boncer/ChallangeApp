int number = 5888452;
string numberInString = number.ToString();
char[] letters = numberInString.ToCharArray();

Console.WriteLine("Wyniki dla liczby: 5888452");

int[] Liczbylicz = new int[10];

foreach (var Liczby in letters)
{
    if (Liczby >= '0' && Liczby <='9')
    {
        int wartość = Liczby - '0';
        Liczbylicz[wartość]++;
    }
}
for (int i = 0; i< Liczbylicz.Length; i++)
{
    Console.WriteLine("{0} => {1}", i, Liczbylicz[i]);
}