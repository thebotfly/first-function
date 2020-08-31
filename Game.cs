using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
   
    {
        bool gameover = false;
        //Run the game
        public void Run()
        {
            Start();
            
            while(gameover == false)
            {
                Update();
            }
           
        }

        //Performed once when the game begins
        public void Start()
        {
            Console.WriteLine("Welcome to my game.");  
        }

        //Repeated until the game ends
        public void Update()
        {
            Console.WriteLine("Test Update");
            Console.ReadKey();
        }

        //Performed once when the game ends
        public void End()
        {
            
        }
    }
}
