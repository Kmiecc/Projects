using System;
using System.Collections.Generic;
using System.Linq;

namespace _59153_I_4
{
    //klasa modelująca słownik inicjacyjny
    class MK_59153_InitialDictionary
    {
        //deklaracja pola prywatnego
        string MK_59153__source;

        //właściwość ustawiająca nam wartość powyższego pola prywatnego (publiczna bo musi być do niej jakiś dostęp)
        public string MK_59153_SetSource
        {
            //setter, bo tylko ją ustawiamy
            set { MK_59153__source = value; }
        }

        //metoda zwracająca słownik wstępny
        public List<string> MK_59153_MakeInitialDicrionary()
        {
            //utworzenie zmiennej źródło i przypisanie jej wartości naszego źródła oraz zadeklarowanie następnego znaku
            string MK_59153_source = MK_59153__source;
            string MK_59153_nextChar;
            //zainicjowanie listy, która będzie zwracana po wykonaniu metody
            List<string> MK_59153_initialDictionary = new List<string>();

            //pętla, która będzie się powtarzała tak długo, jak źródło nie jest puste
            //bierze pierwszy znak, dodaje go do słownika, a następnie z całego źródła usuwa dany znak
            while(MK_59153_source.Length != 0)
            {
                MK_59153_nextChar = MK_59153_source.Substring(0,1);
                MK_59153_initialDictionary.Add(MK_59153_nextChar);
                MK_59153_source = MK_59153_source.Replace(MK_59153_nextChar, "");
            }
            //zwraca wstępny słownik
            return MK_59153_initialDictionary;
        }
    }
    //klasa wykonująca kompresję
    class MK_59153_Compression
    {
        //deklaracja pól prywatnych
        string MK_59153__source;
        List<string> MK_59153__initialDictionary;

        //właściwości ustawiające nam wartości powyższych pól prywatnych (publiczne, bo musi być do nich jakiś dostęp)
        public string MK_59153_SetSource
        {
            //setter, bo tylko ją ustawiamy
            set { MK_59153__source = value; }
        }
        public List<string> MK_59153_SetInitialDictionary
        {
            //setter, bo tylko ją ustawiamy
            set { MK_59153__initialDictionary = value; }
        }
        //metoda zwracająca kod kompresji
        public List<int> MK_59153_GetCompressedList()
        {
            //utworzenie zmiennych 
            string MK_59153_multipleCharacters = "";
            string MK_59153_moreByOneCharacters;
            string MK_59153_nextCharacter;
            string MK_59153_source = MK_59153__source;


            //utworzenie słownika i przypisanie do niego słownika wstępnego
            //byłbym wdzięczny za wyjaśnienie na zajęciach dlaczego "List<string> dictionary = _initialDictionary;" powoduje, że obie zmienne się wiążą i
            //przy zmienieniu dictionary zmienia się również _initialDictionary
            // z góry dziękuję
            List<string> MK_59153_dictionary = MK_59153__initialDictionary.ToList();
            //utworzenie listy kodu kompresji
            List<int> MK_59153_compressedList = new List<int>();
            
            //pętla, która będzie się wykonywała dopóki nie wyczerpiemy całego źródła
            while (MK_59153_source.Length > 0)
            {
                //przypisanie wartości następnego znaku
                MK_59153_nextCharacter = MK_59153_source.Substring(0, 1);
                //multipleCharacters jest to zmienna której idex znajdujący się w słowniku będzie przypisywana do kod kompresji
                //moreByOneCharacters jest to multipleCharacters ale o jeden znak więcej (+ nextCharacter) i są to znaki dopisywane do słownika
                MK_59153_moreByOneCharacters = MK_59153_multipleCharacters + MK_59153_nextCharacter;
                //jeżeli w słowniku znajduje się większa ilość znaków to zwiększymy zwiększymy sprawdzane znaki o kolejny znak i sprawdzimy ponownie
                if (MK_59153_dictionary.Contains(MK_59153_moreByOneCharacters))
                {
                    MK_59153_multipleCharacters = MK_59153_moreByOneCharacters;
                }
                //jeżeli natomiast w słowniku nie znajduje się ta większa ilość znaków to dodamy go do słownika a
                //do kodu kompresji dopiszemy tą mniejszą grupę znaków
                //dodatkowo zamienimy tą mniejszą grupę znaków na pojedynczy znak który nie został dopisany do słownika żeby cała pętla powtórzyła się pomyślnie
                else
                {
                    MK_59153_compressedList.Add(MK_59153_dictionary.IndexOf(MK_59153_multipleCharacters));
                    MK_59153_dictionary.Add(MK_59153_moreByOneCharacters);
                    MK_59153_multipleCharacters = MK_59153_nextCharacter;
                }
                //skracanie źródła żeby przy kolejnym powtórzeniu pętli nextCharacter był faktycznie następnym znakiem
                MK_59153_source = MK_59153_source.Remove(0, 1);    
            }
            // dopisanie ostatniego znaku z ciągu
            MK_59153_compressedList.Add(MK_59153_dictionary.IndexOf(MK_59153_multipleCharacters));
            //zwraca kod kompresji
            return MK_59153_compressedList;
        }
    }

    //klasa wykonująca dekompresję
    class MK_59153_Decompression
    {
        //deklaracja pól prywatnych
        List<string> MK_59153__initialDictionary;
        List<int> MK_59153__compressedList;

        //właściwości ustawiające nam wartości powyższych pól prywatnych (publiczne, bo musi być do nich jakiś dostęp)
        public List<int> MK_59153_SetCompressedList
        {
            //setter, bo tylko ją ustawiamy
            set { MK_59153__compressedList = value; }
        }
        public List<string> MK_59153_SetInitialDictionary
        {
            //setter, bo tylko ją ustawiamy
            set { MK_59153__initialDictionary = value; }
        }
        //metoda zwracająca ciąg zdekompresowany
        public string MK_59153_GetDecompressedString()
        {
            //utworzenie zmiennych
            string MK_59153_decompressedString = "";
            int MK_59153_i = 0;
            //utworzenie list i przypisanie im wartości
            List<int> MK_59153_compressedList = MK_59153__compressedList;
            List<string> MK_59153_dictionary = MK_59153__initialDictionary.ToList();
            

            Console.ForegroundColor = ConsoleColor.Red;
            //pętala wykonująca się dla każdego kodu w kodzie kompresji
            while (MK_59153_i != MK_59153_compressedList.Count)
            {
                //dodawanie do zdekompresowanego stringa odpowiednich znaków
                MK_59153_decompressedString = MK_59153_decompressedString + MK_59153_dictionary[MK_59153_compressedList[MK_59153_i]];
                //obsługiwanie wyjątku, w którym algorytm odwołuje się do nieistniejącego jeszcze indeksu w słowniku
                try
                {
                    //dodawanie do słownika nowych elementów
                    MK_59153_dictionary.Add(MK_59153_dictionary[MK_59153_compressedList[MK_59153_i]] + MK_59153_dictionary[MK_59153_compressedList[MK_59153_i + 1]].Substring(0, 1));
                }
                catch (ArgumentOutOfRangeException MK_59153_ex)
                {
                    //po przechwyceniu błędu w konsoli pokazuje się informacja, na której pozycji skompresowanej listy
                    //algorytm odwołał się do jeszcze nieistniejącego indeksu
                    Console.WriteLine(">Argument out of range exception occurred at " + MK_59153_i + " index of compressed list");
                    //dodawanie do słownika nowych elementów, gdy algorytm odwołuje się do nieistniejącego jeszcze indeksu w słowniku
                    MK_59153_dictionary.Add(MK_59153_dictionary[MK_59153_compressedList[MK_59153_i]] + MK_59153_dictionary[MK_59153_compressedList[MK_59153_i]].Substring(0, 1));
                }
                //iteracja
                MK_59153_i++;
            }
            Console.ResetColor();
            //zwracanie ciągu zdekompresowanego
            return MK_59153_decompressedString;
        }
    }

    class MK_59153_Program
    {
        //deklaracja kodu Źródłowego jako zmienna statyczna 
        static string MK_59153_kodŹródłowy;

        static void Main(string[] args)
        {
            //interfejs użytkownika
            Console.WriteLine("Wpisz własny ciąg znaków do kompresji i dekompresji i naciśnij ENTER");
            Console.WriteLine("Lub nic nie wpisuj i naciśnij ENTER (domyślny ciąg zostanie wykorzystany)");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            string MK_59153_wiadomość = "Podany ciąg: ";
            Console.Write(MK_59153_wiadomość);
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            MK_59153_kodŹródłowy = Console.ReadLine();

            //gdy użytkownik nie poda żadnego ciągu, domyślny ciąg zostanie wykorzystany
            if (MK_59153_kodŹródłowy == "")
            {
                MK_59153_kodŹródłowy = "DBCDDCBBBCDBADBADACBCABACBACDCBCACDACADDBAAADBDCBDDDABACBCCAAACBCDBCBDADDBBBBCCBDDDBBAADDCDCCDADBDCDCCACADCDCAADDCDBAAABBACCDBDABBDCDBCCBCADDDDACCCCCBCBADDCDDCDBBCDCCBDCDBDABDBBDAABBAACACABDACAAADACAABDBCAABADCCADDBCACACBAACA";
                Console.SetCursorPosition(MK_59153_wiadomość.Length, 3);
                Console.WriteLine(MK_59153_kodŹródłowy);
            }
            Console.ResetColor();

            //powołanie do życia obiektów
            MK_59153_InitialDictionary MK_59153_initialDictionary = new MK_59153_InitialDictionary();
            MK_59153_Compression MK_59153_compression = new MK_59153_Compression();
            MK_59153_Decompression MK_59153_decompression = new MK_59153_Decompression();

            //wywoływanie właściwości ustawiającej i przypisanie jemu wartości
            MK_59153_initialDictionary.MK_59153_SetSource = MK_59153_kodŹródłowy;
            //utworzenie listy i przypisanie do niej wartości używając metody
            List<string> MK_59153_initialDictionaryList = MK_59153_initialDictionary.MK_59153_MakeInitialDicrionary();

            //wywoływanie właściwości ustawiających i przypisanie im wartości
            MK_59153_compression.MK_59153_SetSource = MK_59153_kodŹródłowy;
            MK_59153_compression.MK_59153_SetInitialDictionary = MK_59153_initialDictionaryList;
            //utworzenie listy i przypisanie do niej wartości używając metody
            List<int> MK_59153_compressedList = MK_59153_compression.MK_59153_GetCompressedList();
            Console.WriteLine();
            Console.WriteLine("Kod kompresji:");
            //wypisanie do konsoli całego kodu kompresji
            foreach (int MK_59153_numbers in MK_59153_compressedList)
            {
                Console.Write("\x1B[4m" + MK_59153_numbers + "\x1B[0m" + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            //wywoływanie właściwości ustawiających i przypisanie im wartości
            MK_59153_decompression.MK_59153_SetInitialDictionary = MK_59153_initialDictionaryList;
            MK_59153_decompression.MK_59153_SetCompressedList = MK_59153_compressedList;
            //utworzenie stringa i przypisanie do niej wartości używając metody
            string MK_59153_decompressedString = MK_59153_decompression.MK_59153_GetDecompressedString();

            Console.WriteLine();
            Console.WriteLine("Ciąg po dekompresji:");
            //wyświetlenie ciągu po dekompresji
            Console.WriteLine(MK_59153_decompressedString);

            Console.WriteLine();
            //sprawdzenie, czy ciąg po dekompresji jest identyczny jak ten przed kompresją
            //i wyświetlenie użytkownikowi odpowiedniej wiadomości
            if (MK_59153_decompressedString == MK_59153_kodŹródłowy)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Sukces! Ciąg przed kompresją jest identyczny jak po jego dekompresji!");
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Coś poszło nie tak :/");
                Console.ResetColor();
            }

            Console.ReadLine();
        }  
    }
}
