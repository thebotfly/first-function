﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
   
    {
        bool gameover = false;
        string playername = "";
        void RequestName()
        {
            if (playername != "")
            {
                return;
            }
            char input = '';
            while(input != '1')
            {
                Console.Clear();
                Console.WriteLine("Please enter your name.");
                playername = Console.ReadLine();
                Console.WriteLine("Hello" + playername);
                input = GetInput("Yes", "No", "Are you sure you want this name" + playername);
                if(input == '2')
                {
                    Console.WriteLine("Yeah let's get rid of that name, Let's Try again");
                }
            }
        }
        void Explore()
        {
            char input = '';
            input = GetInput("Go Left", "Go Right", "You come to a Pit");
            if(input == '1')
            {
                Console.WriteLine("You decide to use a vine but the vine snapped on you and fall into lava");
                gameover = true;
            }
            else if (input == '2')
            {
                Console.WriteLine("You cross the old bridge and head to the castle");
            }

        } 
        void ViewStats()
        {
            Console.WriteLine(playername);
            Console.WriteLine("Press any key to continue");
            Console.Write(">");
            Console.ReadKey();
        }
        char GetInput(string option1, string option2, string query)
        {
            char input = '';
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
            RequestName();
            Explore(); 
        }


        //Performed once when the game ends
        public void End()
        {
            Console.WriteLine("Thank you for playing my game.");
        }
    }
}
