using System;

namespace Yahtzee
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int[] diceRolls = new int[6];
            diceRolls = RandomDiceRoll(diceRolls);

            for (int i = 0; i < diceRolls.Length; i++)
            {
                Console.WriteLine("Dice {0} = {1}", i, diceRolls[i]);
            }
           
            Console.ReadLine();
        }
        public static int[] RandomDiceRoll (int[] diceRolls) 
        {
            diceRolls = new int[6];
            for (int i = 0; i < diceRolls.Length; i++)
            {
                int randomDice = new Random().Next(1, 6);
                int dice = randomDice;
                diceRolls = new int[] { dice };
                diceRolls[i] = dice;
                

            }
            return diceRolls;
        }
    }
}
