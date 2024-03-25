using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MathGame
{
    internal class Game
    {
       Player Player { get; set; }

       public List<Score> scoreList { get;private set; }
        Operations Gametype { get; set; }
       

        //Default Constructur Player Name="Player 1
        public Game(Player player) 
        
        { 
              this.Player = player;
              scoreList = new List<Score>();
             
              
        }


        public void Start()
        {
            

            Helper.Menu(); ///Display Menu
            string? choice = Console.ReadLine();
            int value=Helper.MenuInputValid(choice);
           
            






        }





    }


    enum Operations { 
        Empty,
        Sum,
        Subtract,
        Muliply,
        Divide,
    }
    public record Score
    {
        string Name { get; set; }
        Operations Operations { get; set; }
        int points { get; set; }
        TimeSpan time { get; set; }

        


    }
}
