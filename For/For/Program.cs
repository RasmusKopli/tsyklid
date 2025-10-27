// See https://aka.ms/new-console-template for more information
//Console.WriteLine("For tsükkel");

//int kogus = 5;

//for (int i = 0; i < kogus; i++);
//{
//    Console.WriteLine("E");
//    Console.Beep();
//}

//string[] objectArray = new string[5]; //array, massiiv mitmest elemendist
//int objectCount = 0; //loend, kui palju kordi küsida
//string temp = "No name"; //muutuja mis hetkel on "tühi"
//while (objectCount < 5) //while tsükkel mis küsib nimesid
//{
//    Console.WriteLine("Sisesta järgmine lemmikloomanimi");
//    temp = Console.ReadLine(); //temp muutujasse väärtuse (mida me tahame) sisestamine
//    objectArray[objectCount] = (temp); //massivi, asukohal objectcount asetame ajutisest muutujast väärtuse
//    objectCount++; //tsükli inkrementatsioon
//}
//Console.WriteLine("Oled sisestanud järgnevad objektid"); //sõnum
//for (int i = 0; i < objectArray.Length; i++)
//{
//    Console.WriteLine($"{i + 1}. Element on: {objectArray[i]}");
//    //kuvame välja reanumbri koos vastava elemendiga, muutuja i abil
//}
//Console.ReadLine(); //peatame programmi klahvisisestuse taha

using System.ComponentModel.Design;

string kasutajanimi = "";
do
{
    Console.WriteLine("Palun sisesta kasutajanimi: ");
    kasutajanimi = Console.ReadLine();
}
while (kasutajanimi != "RasmusKopli");
if (kasutajanimi == "RasmusKopli")
{
    string kasutajaparool = "";
    do
    {
        Console.WriteLine($"Tere, {kasutajanimi}! Palun sisesta oma parool: ");
        kasutajaparool = Console.ReadLine();
    }
    while (kasutajaparool != "Volts");
    if (kasutajaparool == "Volts")
    {
        Console.WriteLine("Parool on õige! Olete sisse logitud.");
    }
    else if (kasutajaparool != "Volts")
    {
        Console.WriteLine($"Vabandust {kasutajanimi}, aga see pole sinu parool.");
    }
    
}
else if (kasutajanimi != "RasmusKopli")
{
    Console.WriteLine("See Kasutajanimi pole registreeritud");
}

