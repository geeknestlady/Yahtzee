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

                Console.WriteLine("Your final roll is:");
                for (int i = 0; i < thirdDiceRolls.Length; i++)
                {                    
                    Console.WriteLine("Dice {0} = {1}", i, thirdDiceRolls[i]);
                }
                int total = DiceCount(thirdDiceRolls);
                Console.WriteLine($"Your total score is {total}");




                int[] computerDiceRolls = new int[5];
                computerDiceRolls = RandomDiceRoll(computerDiceRolls);
                int computerFirstTotal = DiceCount(computerDiceRolls);

                int[] computerSecondDiceRolls = new int[5];
                computerSecondDiceRolls = RandomDiceRoll(computerSecondDiceRolls);
                int computerSecondTotal = DiceCount(computerSecondDiceRolls);

                int[] computerThirdDiceRolls = new int[5];
                computerThirdDiceRolls = RandomDiceRoll(computerThirdDiceRolls);
                int computerThirdTotal = DiceCount(computerThirdDiceRolls);

                int[] computerTotalArray = new int[] { computerFirstTotal, computerSecondTotal, computerThirdTotal };

                int computerTotal = 0;
                for (int i = 0; i < computerTotalArray.Length; i++)
                {
                    int number = 0;
                    if (computerTotal < computerTotalArray[i])
                    {
                        number = computerTotalArray[i];
                    }
                    computerTotal = number;
                }
                Console.WriteLine($"The computer score is {computerTotal}");

                
                if (total >= computerTotal)
                {
                    string message = "You win!";
                    Console.WriteLine(message);
                }
                else
                {
                    string message = "Sorry, you lose.";
                    Console.WriteLine(message);
                }
                
                Console.ReadLine();
            }
        }
        public static int[] RandomDiceRoll(int[] diceRolls)
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
        public static int DiceCount(int[] thirdDiceRolls)
        {
            int counterDiceOne = 0;
            int counterDiceTwo = 0;
            int counterDiceThree = 0;
            int counterDiceFour = 0;
            int counterDiceFive = 0;
            int counterDiceSix = 0;
            int total = 0;
            for (int i = 0; i < thirdDiceRolls.Length; i++)
            {
                if(thirdDiceRolls[i] == 1)
                {
                    counterDiceOne++;
                }
                else if(thirdDiceRolls[i] == 2)
                {
                    counterDiceTwo++;
                }
                else if(thirdDiceRolls[i] == 3)
                {
                    counterDiceThree++;
                }
                else if(thirdDiceRolls[i] == 4)
                {
                    counterDiceFour++;
                }
                else if(thirdDiceRolls[i] == 5)
                {
                    counterDiceFive++;
                }
                else if(thirdDiceRolls[i] == 6)
                {
                    counterDiceSix++;
                }
                int[] totalDiceCount = new int[] {counterDiceOne, counterDiceTwo,
                counterDiceThree, counterDiceFour, counterDiceFive, counterDiceSix };
                

                for (int j = 0; j < totalDiceCount.Length; j++)
                {
                    if (totalDiceCount[j] > total)
                    {
                        total = totalDiceCount[j];
                    }
                }               
            }
            return total;
        }

    }
}
