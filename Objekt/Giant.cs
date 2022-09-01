using System;

    public class Giant
    {
        public int giantHealth = 1000;
        public string giantName = "Grog";

        public int GiantAttack = 50;

        public void attack2(Knight target2)
        {
            target2.Knighthealth -= GiantAttack;
            Console.WriteLine(giantName + "attacks" + target2.knightName);
            Console.WriteLine(target2.knightName + " Health is " + target2.Knighthealth);
        }

    }