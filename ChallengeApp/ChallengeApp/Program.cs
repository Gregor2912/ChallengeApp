int number = 4094662;
string myNumberInString = number.ToString();
char[] letters = myNumberInString.ToArray();

int licz0 = 0;
int licz1 = 0;
int licz2 = 0;
int licz3 = 0;
int licz4 = 0;
int licz5 = 0;
int licz6 = 0;
int licz7 = 0;
int licz8 = 0;
int licz9 = 0;
foreach (char slowo in letters)
{
    if (slowo == '0')
    {
        licz0++;
    }
    else if (slowo == '1')
    {
        licz1++;
    }
    else if (slowo == '2')
    {
        licz2++;
    }
    else if (slowo == '3')
    {
        licz3++;
    }
    else if (slowo == '4')
    {
        licz4++;
    }
    else if (slowo == '5')
    {
        licz5++;
    }
    else if (slowo == '6')
    {
        licz6++;
    }
    else if (slowo == '7')
    {
        licz7++;
    }
    else if (slowo == '8')
    {
        licz8++;
    }
    else if (slowo == '9')
    {
        licz9++;
    }
}
Console.WriteLine(number);

    Console.WriteLine("Liczba 0 wystąpi =>" + licz0);
Console.WriteLine("Liczba 1 wystąpi =>" + licz1);
Console.WriteLine("Liczba 2 wystąpi =>" + licz2);
Console.WriteLine("Liczba 3 wystąpi =>" + licz3);
Console.WriteLine("Liczba 4 wystąpi =>" + licz4);
Console.WriteLine("Liczba 5 wystąpi =>" + licz5);
Console.WriteLine("Liczba 6 wystąpi =>" + licz6);
Console.WriteLine("Liczba 7 wystąpi =>" + licz7);
Console.WriteLine("Liczba 8 wystąpi =>" + licz8);
Console.WriteLine("Liczba 9 wystąpi =>" + licz9);


