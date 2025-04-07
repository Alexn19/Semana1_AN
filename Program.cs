using System;
using System.Collections.Generic;
using Semana1_AN;

class Program
{
    static Dictionary<string, string> map = new Dictionary<string, string>()
    {
        {"left", "The dark and large sewers under Demacia"},
        {"right", "The enormous and magical forest outside Demacia"}
    };

    static string Decision(string question, string[] options)
    {
        string answer;
        do
        {
            Console.WriteLine(question);
            foreach (string option in options)
            {
                Console.WriteLine("- " + option);
            }
            Console.Write("Choose: ");
            answer = Console.ReadLine().ToLower();
        } while (!Array.Exists(options, option => option.ToLower() == answer));
        return answer;
    }

    static void Main()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        Player player = new Player(name);
        player.ShowMessage();

        List<string> inventory = new List<string>();

        Console.WriteLine("\nYou have chosen the sewers");

        string election1 = Decision("Both ways are so dark you can barely see, the left one is bigger and the right one a smaller hole, which one do you choose?", new string[] { "left", "right" });

        Console.WriteLine("You have chosen: " + map[election1]);

        if (election1 == "right")
        {
            Console.WriteLine("You have to lower your head to walk inside that hole, since you are looking at the ground, you find coins that shines when you points it with your flashlight");
            inventory.Add("Coins");
        }
        else
        {
            Console.WriteLine("Since the hole is large, you walk looking up, and get wounded by a nail on the ground");
            player.Health -= 25;
        }

        string election3 = Decision("There is a door hidden behind a rock, but it seems very heavy", new string[] { "push the rock", "Find another way in" });
        switch (election3)
        {
            case "push the rock":
                Console.WriteLine("You push the rock hard");
                break;
            case "find another way in":
                Console.WriteLine("There is a tiny hole to crawl into");
                break;
        }


        int enemies = 5;
        while (enemies > 0)
        {
            Console.WriteLine("An enemy appears, but you are not strong enough to fight them.");
            enemies--;
        }

        for (int i = 0; i < inventory.Count; i++)
        {
            Console.WriteLine("You got: " + inventory[i]);
        }

        Console.WriteLine("The Corwnguard treasure is within your grasp!");
    }
}

