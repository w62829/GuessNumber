using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name for player1");
            var player1 = Console.ReadLine();
            Console.WriteLine("Enter name for player2");
            var player2 = Console.ReadLine();
            var temp = player1;
            while(true)
            {
                
                if(temp == player1)
                {
                    var i = Convert.ToInt32(Console.ReadLine());
                    Game.Guess(i);
                    temp = player2;
                    continue;
                }
                if(temp == player2)
                {
                    var k = Convert.ToInt32(Console.ReadLine());
                    Game.Guess(k);
                    temp = player1;
                    continue;
                }    
                

                
            }
             

        }
    }
    
}
