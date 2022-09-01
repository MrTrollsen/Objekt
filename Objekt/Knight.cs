using System;
public class Knight
{
    public int knightAttack = 5;
    public int knightHealth = 100;
    public string knightName = "Knekt";
    public void attack(Giant target1)
    {
        target1.giantHealth -= knightAttack;
        Console.WriteLine(knightName + " atttacks Grog");
        Console.WriteLine(target1.giantName + " Health is " + target1.giantHealth);
    }
}