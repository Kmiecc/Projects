namespace ExternalModel
{
    public class Models
    {
        public class Książka
        {
            public int IDksiążki;
            public string TytułKsiążki;
            public int CenaKsiążki;
            public int IlośćKsiążek;
        }

        public class SzczegółyWypożyczenia
        {
            public int IdUżytkownika;
            public string ImięOsobyWypożyczającej;
            public string AdresOsobWypożyczającej;
            public int IdWypożyczonejKsiążki;
            public DateTime DataWypożyczenia;
            public int IlośćKsiążek;
        }
    }
}
