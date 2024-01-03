namespace algorytm_dixtry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class Krawedz
    {
        public int waga;
        public Wezel poczatek;
        public Wezel koniec;

        public Krawedz(int waga, Wezel poczatek, Wezel koniec)
        {
            this.waga = waga;
            this.poczatek = poczatek;
            this.koniec = koniec;
            poczatek.listaKrawedzi++;
        }
    }

    public class Graf
    {
        public List<Wezel> wezly = new List<Wezel>();
        public List<Krawedz> krawedzie = new List<Krawedz>();

        public Graf(Wezel s)
        {
            wezly.Add(s);
        }

        public void Add(Wezel s, Wezel k, int waga)
        {
            if (!wezly.Contains(s))
            {
                wezly.Add(s);
            }

            if (!wezly.Contains(k))
            {
                wezly.Add(k);
            }

            var temp = new Krawedz(waga, s, k);

            if (!krawedzie.Contains(temp))
            {
                krawedzie.Add(temp);
            }
        }
        
        public void Dijkstra(Wezel start)
        {
            List<int> odleglosc = new List<int>();
            List<Wezel> poprzedni = new List<Wezel>();

            odleglosc[wezly.IndexOf(start)] = 0;
            poprzedni[wezly.IndexOf(start)] = null;
            foreach(var w in wezly)
            {
                odleglosc[wezly.IndexOf(w)] = int.MaxValue;
                poprzedni[wezly.IndexOf(w)] = null;
            }
        }
    }

    public class Wezel
    {
        public int wartosc;
        public int listaKrawedzi;

        public Wezel(int wartosc)
        {
            this.wartosc = wartosc;
            this.listaKrawedzi = 0;
        }
    }

 
    public class Tabela
    {
        public int d;
        public int p;
    }
}