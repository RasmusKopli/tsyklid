// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Joonistan sulle kolmnurga:");
//int kolmnurgasuurus = int.Parse(Console.ReadLine());

//int i = 1;
//while(i <= kolmnurgasuurus)
//{
//    Console.WriteLine();
//    int j = 1;
//    while(j <= i)
//    {
//        Console.Write(j + " ");
//        j++;
//    }
//    i++;
//}

Console.WriteLine("Tere tulemast MobiFix parandusautomaati! Kuidas saame aidata?");
Console.WriteLine("0- headaega\n1 - tahan telefoni parandada.");
int kasutajaValik = int.Parse(Console.ReadLine());
while(kasutajaValik < 0 && kasutajaValik > 1)
{
    Console.WriteLine("Palun tee oma valik kirjutades vastav arv");
    kasutajaValik = int.Parse(Console.ReadLine());
}
if (kasutajaValik == 0)
{
    Console.WriteLine("Headaega, tulge jälle!");
}
else
{
    Console.WriteLine("Palun sisesta oma telefoni mudel, mida parandada soovid; ");
    Console.WriteLine("1-iPhone\n2-Xiaomi\n-Huawei\n4-Samsung");
    int kasutajaTelefon = int.Parse(Console.ReadLine());
    while(kasutajaTelefon < 1 && kasutajaTelefon > 4)
    {
        kasutajaTelefon = int.Parse(Console.ReadLine());
        Console.WriteLine("Palun tee oma valilk, kirjutades vastav arv, ");
    }
    switch (kasutajaTelefon)
    {
        case 1:
            Console.WriteLine("Aitäh, oma Iphone saad tagasi 1 nädala pärast");
            break;
        case 2:
            Console.WriteLine("Aitäh, oma Xiaomi saad tagasi 1 nädala pärast");
            break;
        case 3:
            Console.WriteLine("Aitäh, oma Huawei saad tagasi 1 nädala pärast");
            break;
        case 4:
            Console.WriteLine("Aitäh, oma Samsungi saad tagasi 2 päeva pärast");
            break;
    }
}