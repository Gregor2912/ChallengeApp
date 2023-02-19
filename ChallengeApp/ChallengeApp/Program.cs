string name = "Tomasz";
char sex = 'm';
int age = 15;
if(sex == 'k'&& age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Tomasz" && age > 30)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (sex == 'm' && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}