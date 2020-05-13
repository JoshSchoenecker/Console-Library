using System;
using libraryConsole.Models;
using System.Collections.Generic;

namespace libraryConsole
{
    public class App
    {

        public Library Library { get; set; }
        public bool Running { get; private set; }

// NOTE program run
        public void Run()
        {
            Library = new Library("Console Library", "Boise");
            Console.Clear();
            System.Console.WriteLine("----------");
            System.Console.WriteLine($"- Welcome to {Library.Title}! -");
            Library.Setup();
            Running = true;

            while (Running)
            {
                MakeSelection();
            }
        }
// NOTE make selection
        public void MakeSelection()
        {

            System.Console.WriteLine("\n - What do you want to do? - \n1) Purchase Book \n2) Checkout Book \n3) Look at Magazines \n4) Quit");
            System.Console.WriteLine("----------");

            string selection = Console.ReadLine();

            switch (selection.ToLower())
            {
                case "purchase book":
                Library.PurchaseBook();
                break;
                case "checkout book":
                Library.CheckoutBook();
                break;
                case "quit":
                Running = false;
                System.Console.WriteLine("Thanks for stopping by Console Library");
                break;
                case "look at magazines":
                Library.ViewMagazines();
                break;
                default:
                System.Console.WriteLine("");
                System.Console.WriteLine("Invalid Selection, Try Again");
                break;
            }
        }
    }
}