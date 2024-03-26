namespace MathGame
{

    internal class Program
    {

        static void Main(string[] args)
        {

            string name = Helper.WelcomeMessage();

            Player player = new Player(name);
            Game game = new Game(player); //Create Game
            game.Start();









        }
    }
}
