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
                string diceName = "ABCDE";
                char[] diceNameArray = diceName.ToCharArray();

                Console.WriteLine("Using commas in between, type 0 to reroll the dice or type the dice's value to keep that dice");
                Console.WriteLine("For example, if you rolled 5,6,2,2,1 and wanted to keep the 2s, type 0,0,2,2,0");

                for (int i = 0; i < diceRolls.Length; i++)
                 {
                    Console.WriteLine("Dice {0} = {1}", diceNameArray[i], diceRolls[i]);
                   
                 }
                Console.WriteLine("Which dice do you want to keep and which do you want to reroll?");                
                string keptDiceInput = Console.ReadLine();

                string[] keptDiceStringArray = keptDiceInput.Split(',');
                int[] keptDiceInt = new int[keptDiceStringArray.Length];
                for (int i = 0; i < keptDiceStringArray.Length; i++)
                {
                    int number = Convert.ToInt32(keptDiceStringArray[i]);
                    keptDiceInt[i] = number;
                }
                
                int[] secondDiceRolls = new int[diceRolls.Length];
                for (int i = 0; i < diceRolls.Length; i++)
                {
                  int number;
                    if (diceRolls[i] == keptDiceInt[i])
                   {
                     number = keptDiceInt[i];
                            
                   }
                   else
                   {
                     number = Dice();
                   }
                                          
                    secondDiceRolls[i] = number;
                }
                for (int i = 0; i < secondDiceRolls.Length; i++)
                {
                    Console.WriteLine("Dice {0} = {1}", i, secondDiceRolls[i]);

                }
                Console.WriteLine("Which dice do you want to keep and which do you want to reroll?");
                string keptDiceInputTwo = Console.ReadLine();

                string[] keptDiceStringArrayTwo = keptDiceInput.Split(',');
                int[] keptDiceIntTwo = new int[keptDiceStringArrayTwo.Length];
                for (int i = 0; i < keptDiceStringArrayTwo.Length; i++)
                {
                    int number = Convert.ToInt32(keptDiceStringArrayTwo[i]);
                    keptDiceIntTwo[i] = number;
                }

                int[] thirdDiceRolls = new int[secondDiceRolls.Length];
                for (int i = 0; i < secondDiceRolls.Length; i++)
                {
                    int number;
                    if (secondDiceRolls[i] == keptDiceInt[i])
                    {
                        number = keptDiceInt[i];

                    }
                    else
                    {
                        number = Dice();
                    }

                    thirdDiceRolls[i] = number;
                }
                for (int i = 0; i < thirdDiceRolls.Length; i++)
                {
                    Console.WriteLine("Dice {0} = {1}", i, thirdDiceRolls[i]);

                }


                Console.ReadLine();
             }
        }
        public static int[] RandomDiceRoll (int[] diceRolls) 
        {            
            for (int i = 0; i < 5; i++)
            {
                int randomDice = new Random().Next(1, 7);
                int dice = randomDice;                
                diceRolls[i] = dice;              

            }
            return diceRolls;
        }
        public static int Dice()
        {
            int randomNum = new Random().Next(1, 7);
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
