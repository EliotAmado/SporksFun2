using System;

namespace SporksFun2
{
    class Program
    {
        static void Main(string[] args)
        {

            //building a random number generator
            Random r = new Random();

            int[] rollTotals = new int[6]; //die 1
            int[] rollTotals2 = new int[6]; //die 2
            int[] CombinedRoll = new int[11]; //Combined roll

            rollTotals[0] = r.Next(1, 7); //1 through 6 rolls  // rollTotals[1] = r.Next(6) + 1;
            rollTotals2[0] = r.Next(1, 7);

            Console.WriteLine("How many dice rolls would you like to simulate? ");
            int Uinput = Convert.ToInt32(Console.ReadLine());

            //simulate the roll of the dies
            for (int i = 0; i < Uinput; i++)
            {
                int roll = r.Next(6);
                int roll2 = r.Next(6);
                int Croll = roll + roll2;


                rollTotals[roll]++;
                rollTotals2[roll2]++;
                CombinedRoll[Croll]++;
            }


            Console.WriteLine("DICE ROLLING SIMULATION RESULTS EACH ' * ' represents 1 % of the total number of rolls. Total number of rolls = " + Uinput);

            //printing out the results from the array
            for (int i = 0; i < 11; i++)
            {
                //Console.WriteLine((i + 2) + ": "+ CombinedRoll[i]); // +2 so the output starts at start at 2
                // have another loop to figure out how many asteriks to print
                int percentage = (CombinedRoll[i] * 100) / Uinput;
                Console.Write((i + 2) + ": ");
                for (int j = 0; j < percentage; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }


        }
    }
}
