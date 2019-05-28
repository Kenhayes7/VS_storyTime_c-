using System;

namespace StoryTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Land of Mischief.");
            Console.WriteLine("Press 'Enter' to continue");
            Console.ReadLine();
            Console.Clear();

            String name;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
            
            

            
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You are not {0} yrs old. Really you look so young.", age);
            

            Console.WriteLine("Would you like to go to the park or cafe?");
            String answer1 = Console.ReadLine();
            

            if (answer1 == "park")
            {
                Console.WriteLine("Ok, Let's go to the park.");
                Console.WriteLine("Do you want to slide or swing?");
                String park = Console.ReadLine();
                if (park == "slide")
                {
                    Console.WriteLine("Ok, lets race to the slide!");
                } else if (park == "swing")
                {
                    Console.WriteLine("Ok, I will push you on the swing");
                } else
                {
                    Console.WriteLine("Please pick one.");
                }
            } else if (answer1 == "cafe")
            {
                Console.WriteLine("Ok, Let's go to the cafe");
                Console.WriteLine("Would you like something to drink or eat?");
                String cafe = Console.ReadLine();
                if (cafe == "drink")
                {
                    Console.WriteLine("Ok, lets go get a cup of tea.");
                } else if (cafe == "eat")
                {
                    Console.WriteLine("Ok, lets go. Their burgers are great.");
                } else
                {
                    Console.WriteLine("Please pick one.");
                }
            } else
            {
                Console.WriteLine("Please pick one.");
            }

            Console.WriteLine("Did you have fun today?");
            String end = Console.ReadLine();

            if (end == "yes")
            {
                Console.WriteLine("Great! I did too.");
            } else if (end == "no")
            {
                Console.WriteLine("Welp! I dont care.");
            } else
            {
                Console.WriteLine("Tell me now!!!");
            }

            Console.WriteLine("Bye. See you next time!");



        }
    }
}
