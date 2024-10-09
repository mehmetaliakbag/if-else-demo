// Kullanıcıdan bir sayı girmesini istiyoruz.

Console.Write("Bir sayı girin: ");

int num = Convert.ToInt32(Console.ReadLine());


#region Control-1

    
// Girdiği sayının 10'dan büyük mü, küçük mü veya 0' mı olduğunu kontrol edip konsol ekranına yazdırıyoruz

if (num > 10)
{
    Console.WriteLine("Girilen sayı 10'dan büyüktür.");
}
else if (num < 10)
{
    Console.WriteLine("Girilen sayı 10'dan küçüktür.");
}
else
{
    Console.WriteLine("Girilen sayı 10'dur.");
}


#endregion

#region Control-2
    

// Girilen sayının tek mi çift mi olduğunu kontrol edip, konsol ekranına yazdırıyoruz

if (num > 0 || num < 0)
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


#endregion


