

Employee pracownik1 = new Employee("Agata", "Suchwałko", 32);
Employee pracownik2 = new Employee("Robert", "Przybysz", 24);
Employee pracownik3 = new Employee("Julia", "Arciszewska", 44);

pracownik1.AddScore(5);
pracownik1.AddScore(4);
pracownik1.AddScore(6);
pracownik1.AddScore(1);
pracownik1.AddScore(4);
pracownik2.AddScore(2);
pracownik2.AddScore(2);
pracownik2.AddScore(3);
pracownik2.AddScore(1);
pracownik2.AddScore(5);
pracownik3.AddScore(5);
pracownik3.AddScore(1);
pracownik3.AddScore(1);
pracownik3.AddScore(1);
pracownik3.AddScore(4);
if (pracownik1.punkty > pracownik2.punkty&&pracownik1.punkty>pracownik3.punkty)
{
    Console.WriteLine("Wynik i dane"+pracownik1.punkty+" "+pracownik1.Imie+ " " + pracownik1.nazwisko+ " " + pracownik1.wiek);
}
else if (pracownik2.punkty > pracownik1.punkty && pracownik1.punkty > pracownik3.punkty)
{
    Console.WriteLine("Wynik i dane"+pracownik2.punkty + " " + pracownik2.Imie + " " + pracownik2.nazwisko + " " + pracownik2.wiek);
}
else if (pracownik3.punkty > pracownik1.punkty && pracownik1.punkty > pracownik3.punkty)
{
    Console.WriteLine("Wynik i dane"+pracownik3.punkty + " " + pracownik3.Imie + " " + pracownik3.nazwisko + " " + pracownik3.wiek);
}


class Employee
{
    private List<int> pkt = new List<int>();

    public Employee(string imie, string nazwisko, int wiek)
    {
        this.Imie = imie;
        this.nazwisko = nazwisko;
        this.wiek = wiek;
    }

    public string Imie { get; private set; }
    public string nazwisko { get; private set; }
    public int wiek { get; private set; }
    public int punkty { get { return this.pkt.Sum(); } }

    public void AddScore(int pkt)
    {
        this.pkt.Add(pkt);
    }

}