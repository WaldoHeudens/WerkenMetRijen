using WerkenMetRijen;

Rij rij = new Rij();
char keuze = '0';
int even;
do
{
    Console.WriteLine("Kies achtereenvolgens:");
    Console.WriteLine(" 0  Stoppen");
    Console.WriteLine(" 1  Toevoegen");
    Console.WriteLine(" 2  Verwijderen");
    Console.WriteLine(" 3  Toon hele rij");
    Console.WriteLine(" 4  Maak de rij leeg");
    Console.Write("Geef je keuze en druk [enter]: ");
    keuze = Console.ReadLine()[0];
    Console.WriteLine();

    switch (keuze)
    {
        case '0':
            break;
        case '1':
            Console.Write("Geef het toe te voegen getal: ");
            rij.Toevoegen(Convert.ToInt32(Console.ReadLine()));
            break;
        case '2':
            even = rij.Uithalen();
            if (even == int.MinValue)
                Console.WriteLine("De rij is leeg");
            else
                Console.WriteLine("Het eerste getal in de rij was " + even);
            Console.WriteLine();
            break;
        case '3':
            Console.WriteLine("De hele rij is:");
            Console.Write(rij.ToString());
            Console.WriteLine();
            break;
        case '4':
            rij.MaakLeeg();
            break;
        default:
            Console.WriteLine("???");
            break;
    }
} while (keuze != '0');


