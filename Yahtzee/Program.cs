using System;

namespace Yahtzee
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool yahtzeeMenu = true;
            while (yahtzeeMenu)
            {
                yahtzeeMenu = YahtzeeMenu();
                int[] diceRolls = new int[5];
                diceRolls = RandomDiceRoll(diceRolls);

                for (int i = 0; i < diceRolls.Length; i++)
                 {
                    Console.WriteLine("Dice {0} = {1}", i, diceRolls[i]);
                   
                 }
                Console.WriteLine("Which numbers do you want to keep?");
                Console.WriteLine("If there are multiple numbers use a comma");
                string keptDiceInput = Console.ReadLine();
                string[] keptDiceString = keptDiceInput.Split(',');
                int[] keptDiceInt = new int[keptDiceString.Length];
                for (int j = 0; j < keptDiceInt.Length; j++)
                {
                    if (diceRolls[j] != keptDiceInt[j])
                    {
                        diceRolls[j] = Dice();
                    }
                    else
                    {
                        diceRolls[j] = diceRolls[j];
                    }
                    Console.WriteLine("Dice {0} = {1}", j, diceRolls[j]);
                }


                Console.ReadLine();
             }
        }
        public static int[] RandomDiceRoll (int[] diceRolls) 
        {            
            for (int i = 0; i < 5; i++)
            {
                int randomDice = new Random().Next(1, 6);
                int dice = randomDice;                
                diceRolls[i] = dice;              

            }
            return diceRolls;
        }
        public static int Dice()
        {
            int randomNum = new Random().Next(1, 6);
            int dice = randomNum;
            return dice;
        }
    
        public static bool YahtzeeMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("Press \"r\" to Play Yahtzee");
            Console.WriteLine("Press \"e\" to Exit Game");
            
            string result = Console.ReadLine();
            if (result == "1")
            {
                //RandomDiceRoll(diceRolls);
                return true;

            }            
            else if (result == "9")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
