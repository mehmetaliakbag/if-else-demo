Console.Write("Bir sayı girin: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 10)
{
    Console.WriteLine("Girilen sayı 10'dan büyüktür.");
}
else if (num < 10)
{
    Console.WriteLine("Girilen sayı 10'dan küçüktür.");
}
else
    Console.WriteLine("Girilen sayı 10'dur.");

if (num > 0)
{
    if (num % 2 == 0)
    {
        Console.WriteLine("Girilen sayı çifttir.");
    }
    else
    {
        Console.WriteLine("Girilen sayı tektir");
    }
}
else if (num < 0)
{
    if (num % 2 == 0)
    {
        Console.WriteLine("Girilen sayı çifttir.");
    }
    else
    {
        Console.WriteLine("Girilen sayı tektir");
    }
}
else
{
    Console.WriteLine("Girilen sayı sıfırdır.");
}

