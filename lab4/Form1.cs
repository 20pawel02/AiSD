using System.Security.Cryptography.X509Certificates;

namespace lab4
{
    public partial class Form1 : Form
    {
        string napis = "";
        List<Wezel2> odwiedzone = new List<Wezel2>();
        public Form1()
        {
            InitializeComponent();
        }

        void A(Wezel w)
        {
            napis += " " + w.wartosc.ToString();
            for (int i = 0; i < w.dzieci.Count; i++)
            {
                A(w.dzieci[i]);
            }
            MessageBox.Show(napis);
        }

        void A(Wezel2 w)
        {

            if (odwiedzone.Contains(w))
            {
                return;
            }

            napis += " " + w.wartosc.ToString();
            odwiedzone.Add(w);

            foreach (var sasiad in w.sasiedzi)
            {
                if (!odwiedzone.Contains(sasiad))
                    A(sasiad);
            }
        }
            
        private void button_start_Click(object sender, EventArgs e)
        {
            var w1 = new Wezel2(2);
            var w2 = new Wezel2(3);
            var w3 = new Wezel2(1);
            var w4 = new Wezel2(5);
            var w5 = new Wezel2(7);
            var w6 = new Wezel2(9);
            var w7 = new Wezel2(4);
            w1.Add(w2);
            w2.Add(w3);
            w3.Add(w4);
            w4.Add(w5);
            w5.Add(w6);
            w5.Add(w7);
            w7.Add(w1);
            odwiedzone.Clear();
            napis = "";
            A(w1);
            MessageBox.Show(napis);
        }
    }

    class Wezel
    {
        public int wartosc;
        public List<Wezel> dzieci = new List<Wezel>();

        public Wezel(int liczba)
        {
            this.wartosc = liczba;
        }
    }

    class Wezel2
    {
        public int wartosc;
        public List<Wezel2> sasiedzi = new List<Wezel2>();

        public Wezel2(int liczba)
        {
            this.wartosc = liczba;
        }

        public bool Add(Wezel2 s)
        {
            if (this == s)
            {
                return false;
            }

            bool wynik = false;

            if (!this.sasiedzi.Contains(s))
            {
                this.sasiedzi.Add(s);
                wynik = true;
            }

            if (!s.sasiedzi.Contains(this))
            {
                this.sasiedzi.Add(this);
                wynik = true;
            }
            return wynik;
        }
    }


    //Binarne drzewo przeszukiwac
    //5,3,7,9,5,3,7,4
    //w clasie Wezel3 napisac metode toString() aby wyswietlic watrosc wezla
    // L / P odnosi sie do dzieci wezla
    // [3]
    // [5] L|P| | LP
    // TreeView

    class DrzewoBinarne
    {
        public Wezel3 korzen;
        public int liczbaWezlow = 0;

        void Add(int liczba)
        {
            Wezel3 rodzic = this.ZnajdzRodzica(liczba);
            rodzic.Add(liczba);
        }

        private Wezel3 ZnajdzRodzica(int liczba)
        {
            var w = this.korzen;
            while (true)
            {
                if (liczba < w.wartosc)
                {
                    if (w.dziecko_lewe != null)
                    {
                        w = w.dziecko_lewe;
                    }
                    else
                    {
                        return w;
                    }
                }
                else
                {
                    if (w.dziecko_prawe != null)
                    {
                        w = w.dziecko_prawe;
                    }
                    else
                    {
                        return w;
                    }
                }
            }
        }
    }

    class Wezel3
    {
        public int wartosc;
        public Wezel3 rodzic;
        public Wezel3 dziecko_prawe;
        public Wezel3 dziecko_lewe;

        public Wezel3(int wartosc)
        {
            this.wartosc = wartosc;
        }

        public void Add(int liczba)
        {
            var dziecko = new Wezel3(liczba);
            dziecko.rodzic = this;
            if (liczba < this.wartosc)
            {
                this.dziecko_lewe = dziecko;
            }
            else
            {
                this.dziecko_prawe = dziecko;
            }
        }
    }

    //do funkcji podajemy liczbe, funkcja zwraca wezel o takiej wartosci
    //do dokonczenia
    public Wezel3 Znajdz(int liczba)
    {

    }

    public Wezel3 ZnajdzNajmniejszy(Wezel3 w)
    {

    }

    public Wezel3 ZnajdzNajwiekszy(Wezel3 w)
    {

    }

    public Wezel3 Nastepnik(Wezel3 w)
    {
        //3 warunki
        //1. jest prawe dziecko -> jnajmniejszy elem w prawym poddrzewie
        //2. wezel nie posiada prawego dziecka -> idz do gory tak dlugo az to do czego doszedles nie bedzie lewym dzieckiem
        //3. gdy nie ma rodzica jak w pkt 2. -> nie ma nastepnika
    }
}
//do zrobienia BFS https://en.wikipedia.org/wiki/Breadth-first_search najlepiej na liscie
//kolejka na liscie -> dodawac sasiadow ktorzy sa polaczoni z aktualnym wezlem i nie zostali jeszcze odwiedzeni