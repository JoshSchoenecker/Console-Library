using System;
using System.Collections.Generic;

namespace libraryConsole.Models
{
    public class Library
    {
        private List<Book> Books { get; set; } = new List<Book>();
        public string Title { get; set; }
        public string Location { get; set; }

        public Library(string title, string location)
        {
            Title = title;
            Location = location;
            Books = new List<Book>();
        }


        public void Setup()
        {
            Book whereTheSidewalkEnds = new Book("Where the Sidewalk Ends", "Shel Silverstein");
            Book eragon = new Book("Eragon", "Christopher Paolini");
            Book childrenOfBloodAndBone = new Book("Children Of Blood And Bone", "Henry Holt");
            Book theDrownedCities = new Book("The Drowned Cities", "Paolo Bacigalupi");
            Books.Add(whereTheSidewalkEnds);
            Books.Add(eragon);
            Books.Add(childrenOfBloodAndBone);
            Books.Add(theDrownedCities);
            PrintBooks();
        }

        public void ViewMagazines()
        {
            throw new NotImplementedException();
        }

        public void CheckoutBook()
        {
            PrintBooks();
            string selection = Console.ReadLine();
            int index;
            if (int.TryParse(selection, out index) != false && index - 1 < Books.Count && index - 1 > -1)
            {
                Book book = Books[index -1];

                if (!book.Available)
                {
                    System.Console.WriteLine("This book is not in stock");
                }
                else
                {
                    book.Available = false;
                    System.Console.WriteLine($"You Checked out {book.Title} by {book.Author}");
                }
            }
            else
            {
                System.Console.WriteLine("Not a book!");
            }
            
        }

        public void PurchaseBook()
        {
            throw new NotImplementedException();
        }

        internal void PrintBooks()
        {
            for (int i = 0; i < Books.Count; i++)
            {
                System.Console.WriteLine($"{i + 1}) {Books[i].Title} - Author: {Books[i].Author}");
            }
        }
        internal void PrintBooks(bool available)
        {
            System.Console.WriteLine(" - Your Books - ");
            for (int i = 0; i < Books.Count; i++)
            {
                Book book = Books[i];
                if (book.Available == available)
                {
                    System.Console.WriteLine($"{i + 1} - {book.Title}");
                }
            }
        }

    }

}