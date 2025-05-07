using System.Runtime.CompilerServices;

namespace RedVsBlue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();


            List<int> teamBlue = new List<int>();
            List<int> teamRed = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                teamBlue.Add(rng.Next(1,101));
                teamRed.Add(rng.Next(1, 101));
            }

            int blueWins = 0;
            int redWins = 0;
            int ties = 0;
            for (int i = 0; i < 100; i++)
            {
                if (teamBlue[i] > teamRed[i])
                    blueWins++;
                else if (teamRed[i] > teamBlue[i])
                    redWins++;
                else
                    ties++;
                //Console.WriteLine(i + ":" + teamBlue[i] + "," + teamRed[i]);
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Blue wins: " + blueWins);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Red wins: " + redWins);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ties: " + ties);
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
