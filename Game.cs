using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
   
    {
        bool gameover = false;
        string name = "";
        void RequestName(ref string name)
        {
            
            char input = ' ';
            while(input != '1')
            {
                Console.Clear();
                Console.WriteLine("Please enter a new name for" + name);
                name = Console.ReadLine();
                Console.WriteLine("Hello" + "name");
                input = GetInput("Yes", "No", "Are you sure you want this name" + name + "?");
                if(input == '2')
                {
                    Console.WriteLine("Yeah let's get rid of that name, Let's Try again");
                }
            }
        }
        void Explore()
        {
            string petname = "odd looking dragon";
            string enemyname = "wild gunman";
            char input = ' ';
            input = GetInput("Go Left", "Go Right", "You come to a Pit");
            if(input == '1')
            {
                Console.WriteLine("You choose to go around the pit and you find a very odd looking dragon trapped by some other travelers you sneak by them and open the trap freeing the dragon it scared off the other travelers and it starts following you");
                Console.WriteLine("Do you want to name the dragon");
                RequestName(ref petname);
                Console.WriteLine("New name is " + petname);
                Console.ReadKey();
            }
            else if (input == '2')
            {
                Console.WriteLine("You cross the old bridge and head to the castle");
            }
            Console.Clear();
            Console.WriteLine("One of the travelers runs at you wanting to kill you for freeing that dragon that they were going eat");
            int playerHealth = 150;
            int enemyHealth = 75;
            gameover = StartBattle(ref playerHealth, ref enemyHealth);

        } 
        bool StartBattle(ref int playerHealth,  ref int enemyHealth)
        {
            char input = ' ';
            while(playerHealth > 0 && enemyHealth > 0)
            {
                input = GetInput("Attack", "Defend", "What will you do");
                if(input == '1')
                {
                    Console.WriteLine("You attacked and did 15 damage");
                }
                else if(input == '2')
                {
                    Console.WriteLine("You blocked the enemy's attack and took less damage");
                    Console.ReadKey();
                    continue;
                }
                playerHealth = 150;
                Console.WriteLine("The enemy attacked and 5 damage!");
                Console.ReadKey();
            }
            return playerHealth <= 0;
            
        }
        void ViewStats()
        {
            Console.WriteLine(name);
            Console.WriteLine("Press any key to continue");
            Console.Write(">");
            Console.ReadKey();
        }
        char GetInput(string option1, string option2, string query)
        {
            char input = ' ';
            while(input != '1' && input != '2')
            {
                Console.WriteLine(query);
                Console.WriteLine("1. " + option1);
                Console.WriteLine("2." + option2);
                Console.WriteLine("3. View Stats");
                Console.Write(">");
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if(input == '3')
                {
                    ViewStats();
                }
            }
            return input;
        }
        //Run the game
        public void Run()
        {
            Start();
            
            while(gameover == false)
            {
                Update();
            }

            End();
           
        }

        //Performed once when the game begins
        public void Start()
        {
            Console.WriteLine("Welcome to my game.");  
        }

        //Repeated until the game ends
        public void Update()
        {
            RequestName(ref name);
            Explore(); 
        }


        //Performed once when the game ends
        public void End()
        {
            Console.WriteLine("Thank you for playing my game.");
        }
    }
}
