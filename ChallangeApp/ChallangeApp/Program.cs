using ChallangeApp;

Employee Employee1 = new Employee("Zenek", "Len", 32);
Employee Employee2 = new Employee("Bogdan", "Pro", 40);
Employee Employee3 = new Employee("Filip", "Dran", 23);

// 11
Employee1.AddGrands(9);
Employee1.AddGrands(5);
Employee1.AddGrands(3);
Employee1.AddGrands(8);
Employee1.AddGrands(7);
// 12
Employee2.AddGrands(4);
Employee2.AddGrands(10);
Employee2.AddGrands(7);
Employee2.AddGrands(9);
Employee2.AddGrands(3);
// 26
Employee3.AddGrands(9);
Employee3.AddGrands(3);
Employee3.AddGrands(3);
Employee3.AddGrands(4);
Employee3.AddGrands(6);


var result1 = Employee1.Result;
var result2 = Employee2.Result;
var result3 = Employee3.Result;

Console.WriteLine($"{Employee1.FirstName} {Employee1.LastName} | Uzyskał: {result1} pkt");
Console.WriteLine($"{Employee2.FirstName} {Employee2.LastName} | Uzyskał: {result2} pkt");
Console.WriteLine($"{Employee3.FirstName} {Employee3.LastName} | Uzyskał: {result3} pkt");
Console.WriteLine("");


if (result1 > result2 && result1 > result3)
{

    Console.WriteLine($"Pracownik z najlepszą oceną:{Employee1.FirstName} {Employee1.LastName}");
    Console.WriteLine($"Wiek: {Employee1.Age} lat");
    Console.WriteLine($"Wynik: {result1}");

}
else if (result2 > result1 && result2 > result3)
{
    Console.WriteLine($"Pracownik z najlepszą oceną:{Employee2.FirstName} {Employee2.LastName}");
    Console.WriteLine($"Wiek: {Employee2.Age} lat");
    Console.WriteLine($"Wynik: {result2}");

}
else
{
    Console.WriteLine($"Pracownik z najlepszą oceną:{Employee3.FirstName} {Employee3.LastName}");
    Console.WriteLine($"Wiek: {Employee3.Age} lat");
    Console.WriteLine($"Wynik: {result3}");

}



