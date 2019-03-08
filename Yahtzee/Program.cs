using System;

namespace Yahtzee
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int[] diceRolls = new int[5];
            diceRolls = RandomDiceRoll(diceRolls);

            for (int i = 0; i < diceRolls.Length; i++)
            {
                Console.WriteLine("Dice {0} = {1}", i, diceRolls[i]);
            }
           
            Console.ReadLine();
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
    }
}
