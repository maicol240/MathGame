using System.Diagnostics;

namespace MathGame
{
    internal class Game
    {
        Player Player { get; set; }

        public List<Score> scoreList { get; private set; }
        private Gametype gametype { get; set; }


        //Default Constructur Player Name="Player 1
        public Game(Player player)

        {
            this.Player = player;
            scoreList = new List<Score>();


        }



        //MeThods
        public void Start()
        {
            bool start = true;
            while (start)
            {

                Helper.DisplayMenu(); ///Display Menu
                string? value = Console.ReadLine();
                int choice = Helper.MenuInputValid(value); /// Gets the Choice
                Console.Clear();
                switch (choice)
                {

                    case 1:
                        this.gametype = Gametype.Sum;
                        scoreList.Add(StartRound(Helper.Add, this));

                        break;
                    case 2:
                        this.gametype = Gametype.Subtract;
                        scoreList.Add(StartRound(Helper.Substraction, this));
                        break;
                    case 3:
                        this.gametype = Gametype.Muliply;
                        scoreList.Add(StartRound(Helper.Multiply, this));
                        break;

                    case 4:
                        this.gametype = Gametype.Divide;
                        scoreList.Add(StartRound(Helper.Divide, this));
                        break;

                    case 5:
                        Console.WriteLine("Coming soon");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 6:
                        Console.WriteLine("\tScore-List");
                        foreach (Score score in scoreList)
                        {
                            Console.WriteLine($"Player Name: {score.Name} Points:{score.Points}  GameType:{score.Operations}  Time: {score.Time}");
                        }
                        break;
                    case 7:
                        Console.WriteLine("BYE");
                        start = false;
                        break;









                }



            }



        }

        public Score StartRound(Helper.Operations operations, Game game)
        {

            int size = 5;
            string math;
            Random random = new Random();
            int score = 0;

            //// For Formating purposes//
            if (gametype == Gametype.Sum)
            {
                math = "+";

            }
            else if (gametype==Gametype.Subtract)
            {
                math = "-";

            }
            else if (gametype==Gametype.Muliply)
            {
                math = "*";
            }
            else
                math = "/";
            //////
            Stopwatch stopwatch = new Stopwatch();


            for (int i = 0; i < size; i++)   /// Math Starts here
            {

                ///Numbers from 
                int number = random.Next(1, 101);
                int number2 = random.Next(1, 101);
                int answer;
                stopwatch.Start();
                Helper.Write($"{number} {math} {number2}= ", ConsoleColor.Blue);
                while (!int.TryParse(Console.ReadLine(), out answer))
                {

                    Helper.WriteLine("\nWrong input Try Again", ConsoleColor.Red);
                    Console.WriteLine();
                    Helper.Write($"{number} {math} {number2}= ", ConsoleColor.Blue);
                }

                if (answer == operations(number, number2))
                {
                    Helper.WriteLine("Correct", ConsoleColor.Green);
                    Console.WriteLine("Press any Key to continue");
                    Console.ReadKey();
                    Console.Clear();


                    score++;
                }   ///Check the answer and gives an score

                else
                {
                    Helper.WriteLine("WRONG", ConsoleColor.Red);
                    Console.WriteLine("Press any Key to continue");
                    Console.ReadKey();
                    Console.Clear();

                }


            }    // Score and operations are being made here

            stopwatch.Stop();

            TimeSpan time = stopwatch.Elapsed;
            string FormatedTime = time.ToString(@"mm\:ss");
            Console.WriteLine($"You Made {score} points");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            Score Final = new Score(game.Player.Name, gametype, score, FormatedTime);
            return Final;



        } //Round menu and all input is calculated here 








    }








}












public enum Gametype
{
    Empty,
    Sum,
    Subtract,
    Muliply,
    Divide,
}
public record Score(string Name, Gametype Operations, int Points, string Time);

