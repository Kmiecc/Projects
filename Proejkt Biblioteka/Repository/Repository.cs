using Newtonsoft.Json;
using static ExternalModel.Models;

namespace Repository
{
    class Operations
    {
        public static string localPath = Environment.CurrentDirectory + @"\database.json";
        public static List<SzczegółyWypożyczenia> borrowList = new List<SzczegółyWypożyczenia>();
        public string getStringAndValidIt(string tekstWyświetlany)
        {
            string? stringWpisany = "";

            while (stringWpisany == null || stringWpisany == "")
            {
                Console.Write(tekstWyświetlany);
                stringWpisany = Console.ReadLine();
                if (!(stringWpisany == null || stringWpisany == ""))
                {
                    return stringWpisany;
                }
                Console.WriteLine("Wprowadzony ciąg znaków nie może być pusty");
                Console.WriteLine("Możesz wrócić do menu wpisując Q");
            }
            return stringWpisany;
        }

        public string getIntAndValidIt(string tekstWyświetlany)
        {
            bool isInt = false;
            int liczbaOddana = default;
            string? wpisanaWartość = "";
            while (!isInt)
            {
                Console.Write(tekstWyświetlany);
                wpisanaWartość = Console.ReadLine();
                isInt = Int32.TryParse(wpisanaWartość, out liczbaOddana);
                if (isInt == false && wpisanaWartość == "Q")
                {
                    return wpisanaWartość;
                }
                else if(isInt == true)
                {
                    return wpisanaWartość;
                }
                
                Console.WriteLine("W to pole należy wpisać liczbę");
                Console.WriteLine("Możesz wrócić do menu wpisując Q");
            }
            return wpisanaWartość;
        }

        public virtual void wykonaj()
        {

        }
    }
    class AddBook : Operations
    {
        public override void wykonaj()
        {
            try
            {
                var json = File.ReadAllText(localPath);
                var books = JsonConvert.DeserializeObject<List<Książka>>(json);
                Książka book = new Książka();

                Console.WriteLine("Id Książki: {0}", book.IDksiążki = books.Last().IDksiążki + 1);

                string bookName = getStringAndValidIt("Nazwa książki:");
                if (bookName == "Q")
                {
                    return;
                }

                string bookPrice = getIntAndValidIt("Cena książki:");
                if (bookPrice == "Q")
                {
                    return;
                }

                string bookAmount = getIntAndValidIt("Liczba książek:");
                if (bookPrice == "Q")
                {
                    return;
                }

                book.TytułKsiążki = bookName;
                book.CenaKsiążki = Int32.Parse(bookPrice);
                book.IlośćKsiążek = Int32.Parse(bookAmount);
                books.Add(new Książka
                {
                    IDksiążki = book.IDksiążki,
                    CenaKsiążki = book.CenaKsiążki,
                    IlośćKsiążek = book.IlośćKsiążek,
                    TytułKsiążki = book.TytułKsiążki
                });
                json = JsonConvert.SerializeObject(books);
                File.WriteAllText(localPath, json);

                Console.WriteLine("Dodano książkę do bazy");
            }
            catch
            {
                try
                {
                    File.WriteAllText(localPath, JsonConvert.SerializeObject(new List<Książka>()));
                    Console.WriteLine("Utworzono bazę danych, można dodawać książki do biblioteki");
                }
                catch
                {
                    Console.WriteLine("Wystąpił błąd przy tworzeniu bazy danych, spróbuj ponownie.");
                }
            }
        }
    }

    class RemoveBook : Operations
    {
        public override void wykonaj()
        {
            try
            {
                var json = File.ReadAllText(localPath);
                var books = JsonConvert.DeserializeObject<List<Książka>>(json);
                Książka book = new Książka();

                string bookID = getIntAndValidIt("Wpisz ID książki aby ją usunąć : ");
                if (bookID == "Q")
                {
                    return;
                }

                var foundBook = books.FirstOrDefault(x => x.IDksiążki == Int32.Parse(bookID));

                if (foundBook != null)
                {
                    books.Remove(foundBook);
                    json = JsonConvert.SerializeObject(books);
                    File.WriteAllText(localPath, json);
                    Console.WriteLine("Książka o Id {0} została usunięta", bookID);
                }
                else
                {
                    Console.WriteLine("Nie znaleziono książki o podanym Id");
                }
            }
            catch
            {
                Console.WriteLine("Nie utworzono instancji bazy danych, spróbuj najpierw dodać książkę");
            }
        }
    }

    class SearchBook : Operations
    {
        public override void wykonaj()
        {
            try
            {
                var json = File.ReadAllText(localPath);
                var books = JsonConvert.DeserializeObject<List<Książka>>(json);


                string bookID = getIntAndValidIt("Wyszukaj książke po ID :");
                if (bookID == "Q")
                {
                    return;
                }

                var foundBook = books.FirstOrDefault(x => x.IDksiążki == Int32.Parse(bookID));
                if (foundBook != null)
                {
                    Console.WriteLine("ID książki :{0}\n" +
                        "Nazwa książki :{1}\n" +
                        "Cena książki :{2}\n" +
                        "Ilość książek :{3}", foundBook.IDksiążki, foundBook.TytułKsiążki, foundBook.CenaKsiążki, foundBook.IlośćKsiążek);
                }
                else
                {
                    Console.WriteLine("Nie znaleziono książki o id {0}", Int32.Parse(bookID));
                }
            }
            catch
            {
                Console.WriteLine("Nie utworzono instancji bazy danych, spróbuj najpierw dodać książkę");
            }
        }
    }
    class Borrow : Operations
    {
        public override void wykonaj()
        {
            try
            {
                var json = File.ReadAllText(localPath);
                var books = JsonConvert.DeserializeObject<List<Książka>>(json);
                Książka book = new Książka();
                SzczegółyWypożyczenia borrow = new SzczegółyWypożyczenia();
                Console.WriteLine("ID użytkownika : {0}", (borrow.IdUżytkownika = borrowList.Count + 1));

                string userName = getStringAndValidIt("Nazwa użytkownika:");
                if (userName == "Q")
                {
                    return;
                }
                string bookID = getIntAndValidIt("Id Książki :");
                if (bookID == "Q")
                {
                    return;
                }
                string bookAmount = getIntAndValidIt("Ilość Książek : ");
                if (bookAmount == "Q")
                {
                    return;
                }
                string userAddress = getStringAndValidIt("Adres osoby wypożyczajacej : ");
                if (userAddress == "Q")
                {
                    return;
                }
                borrow.ImięOsobyWypożyczającej = userName;
                borrow.IdWypożyczonejKsiążki = Int32.Parse(bookID);
                borrow.IlośćKsiążek = Int32.Parse(bookAmount);
                borrow.AdresOsobWypożyczającej = userAddress;


                borrow.DataWypożyczenia = DateTime.Now;
                Console.WriteLine("Data - {0} i Czas - {1}", borrow.DataWypożyczenia.ToShortDateString(), borrow.DataWypożyczenia.ToShortTimeString());

                var foundBook = books.FirstOrDefault(x => x.IDksiążki == borrow.IdWypożyczonejKsiążki);

                if (foundBook != null)
                {
                    if (foundBook.IlośćKsiążek - borrow.IlośćKsiążek >= 0)
                    {
                        foundBook.IlośćKsiążek = foundBook.IlośćKsiążek - borrow.IlośćKsiążek;
                        json = JsonConvert.SerializeObject(books);
                        File.WriteAllText(localPath, json);
                    }
                    else
                    {
                        Console.WriteLine("Tylko {0} książek znaleziono", foundBook.IlośćKsiążek);
                    }
                }
                else
                {
                    Console.WriteLine("Książka id {0} nie znaleziona", borrow.IdWypożyczonejKsiążki);
                }
            }
            catch
            {
                Console.WriteLine("Nie utworzono instancji bazy danych, spróbuj najpierw dodać książkę");
            }
        }
    }
    class PokażWszystkieKsiążki : Operations
    {
        public override void wykonaj()
        {
            try
            {
                var json = File.ReadAllText(localPath);
                var books = JsonConvert.DeserializeObject<List<Książka>>(json);
                json = JsonConvert.SerializeObject(books);
                File.WriteAllText(localPath, json);

                if (books.Count != 0)
                {
                    foreach (var book in books)
                    {
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Id: " + book.IDksiążki);
                        Console.WriteLine("Tytuł: " + book.TytułKsiążki);
                        Console.WriteLine("Cena: " + book.CenaKsiążki);
                        Console.WriteLine("Ilość: " + book.IlośćKsiążek);
                        Console.WriteLine("------------------------------\n");
                    }
                }
                else
                {
                    Console.WriteLine("Nie ma książek w bibliotece");
                }
            }
            catch
            {
                Console.WriteLine("Nie utworzono instancji bazy danych, spróbuj najpierw dodać książkę");
            }
        }
    }
    class ReturnBook : Operations
    {
        public override void wykonaj()
        {
            try
            {
                var json = File.ReadAllText(localPath);
                var books = JsonConvert.DeserializeObject<List<Książka>>(json);
                Książka book = new Książka();

                string bookID = getIntAndValidIt("Id Książki :");
                if (bookID == "Q")
                {
                    return;
                }

                string returnCount = getIntAndValidIt("Liczba książek:");
                if (returnCount == "Q")
                {
                    return;
                }


                var foundBook = books.FirstOrDefault(x => x.IDksiążki == Int32.Parse(bookID));

                if (foundBook != null)
                {
                    if (Int32.Parse(returnCount) <= 0)
                    {
                        Console.WriteLine("Nie można oddać {0} książek", returnCount);
                    }
                    else
                    {
                        foundBook.IlośćKsiążek = Int32.Parse(returnCount) + foundBook.IlośćKsiążek;
                        json = JsonConvert.SerializeObject(books);
                        File.WriteAllText(localPath, json);
                    }
                }
                else
                {
                    Console.WriteLine("Nie znaleziono książki o id {0}", bookID);
                }
            }
            catch
            {
                Console.WriteLine("Nie utworzono instancji bazy danych, spróbuj najpierw dodać książkę");
            }
        }
    }


}