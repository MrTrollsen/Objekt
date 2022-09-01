using System;

Knight Knekt = new Knight();
Giant Grog = new Giant();

while (Knekt.Knighthealth >= 1 && Grog.giantHealth >= 1)
{
Knekt.attack(Grog);

Grog.attack2(Knekt);
}

Console.ReadLine();


