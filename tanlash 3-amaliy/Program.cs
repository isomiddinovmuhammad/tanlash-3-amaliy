using System;
//1-amaliy vazifa
Console.Write("So'zni kiriting: ");
string soz = Console.ReadLine();

string teskari = new string(soz.Reverse().ToArray());

if (soz == teskari)
    Console.WriteLine("Palindrom");
else
    Console.WriteLine("Palindrom emas");

//2-masala
Console.Write("Selsiy bo'yicha temperaturani kiriting: ");
double c = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Qaysi birlikka o'tkazay? (F / K): ");
string tanlov = Console.ReadLine().ToUpper();

switch (tanlov)
{
    case "F":
        double f = (c * 9 / 5) + 32;
        Console.WriteLine($"Selsiy: {c}, Fahrenheit: {f}");
        break;

    case "K":
        double k = c + 273.15;
        Console.WriteLine($"Selsiy: {c}, Kelvin: {k}");
        break;

    default:
        Console.WriteLine("Noto'g'ri tanlov!");
        break;
}

//3-masala
Console.Write("Sonlarni vergul bilan kiriting (masalan: 9,4,7,2,5): ");
int[] sonlar = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

Console.WriteLine("1 - O'sish tartibida");
Console.WriteLine("2 - Kamayish tartibida");
Console.Write("Tanlang: ");
int tanlov1 = int.Parse(Console.ReadLine());

switch (tanlov1)
{
    case 1:
        Array.Sort(sonlar);
        Console.WriteLine("Tartiblangan: " + string.Join(", ", sonlar));
        break;

    case 2:
        Array.Sort(sonlar);
        Array.Reverse(sonlar);
        Console.WriteLine("Teskari tartib: " + string.Join(", ", sonlar));
        break;

    default:
        Console.WriteLine("Noto'g'ri tanlov!");
        break;
}

//4masala
Console.Write("Matnni kiriting: ");
string matn = Console.ReadLine();

Dictionary<char, int> hisob = new Dictionary<char, int>();

foreach (char c in matn)
{
    if (hisob.ContainsKey(c))
        hisob[c]++;
    else
        hisob[c] = 1;
}

foreach (var item in hisob)
{
    Console.WriteLine($"'{item.Key}': {item.Value} marta");
}
        