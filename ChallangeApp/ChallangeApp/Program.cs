
string name = "Ewa";
bool famale = true;
int age = 29;


if (famale == true)
{
    if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa, lat 33");
    }
    else if (age < 30)
    {
        Console.WriteLine("Kobieta ponizej 33 lat");
    }
}
else if (age < 18)
{
    Console.WriteLine("Niepelnoletni mezczyzna");
}
