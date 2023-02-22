using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace LibraryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository.AddBook addBook = new Repository.AddBook();
            Repository.RemoveBook removeBook = new Repository.RemoveBook();
            Repository.SearchBook searchBook = new Repository.SearchBook();
            Repository.Borrow borrow = new Repository.Borrow();
            Repository.ReturnBook returnBook = new Repository.ReturnBook();
            Repository.PokażWszystkieKsiążki pokażWszystkieKsiążki = new Repository.PokażWszystkieKsiążki();

            while (true)
            {
                Console.WriteLine("\nMenu\n" +
                "1)Dodaj książkę\n" +
                "2)Usuń książkę\n" +
                "3)Wyszukaj książkę\n" +
                "4)Wypożycz książkę\n" +
                "5)Oddaj książkę\n" +
                "6)Zamknij program\n" +
                "7)Pokaż ksiązki w biblitece\n");
                Console.Write("Wybierz co chcesz zrobić :");
                bool isRightAnswer = Int32.TryParse(Console.ReadLine(), out int option);
                if (!isRightAnswer)
                {
                    Console.WriteLine("Niepoprawne polecenie\nSpróbuj ponownie !!!");
                    continue;
                }

                if (option == 1)
                {
                    addBook.wykonaj();
                }
                else if (option == 2)
                {
                    removeBook.wykonaj();
                }
                else if (option == 3)
                {
                    searchBook.wykonaj();
                }
                else if (option == 4)
                {
                    borrow.wykonaj();
                }
                else if (option == 5)
                {
                    returnBook.wykonaj();
                }
                else if (option == 6)
                {
                    Console.WriteLine("Dziękujemy za skorzystanie z systemu biblioteki, do widzenia");
                    break;
                }
                else if (option == 7)
                {
                    pokażWszystkieKsiążki.wykonaj();
                }
                else
                {
                    Console.WriteLine("Niepoprawne polecenie\nSpróbuj ponownie !!!");
                }
            }

            Console.ReadLine();
        }
    }
}

// Wykonał:
// Daniel Kuchciński 17767