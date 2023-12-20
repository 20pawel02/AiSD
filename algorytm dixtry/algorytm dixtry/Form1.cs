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

        public Graf(Wezel wezel)
        {
            wezly.Add(wezel);
        }

        public void Add(Wezel wezel, Wezel krawedz, int waga)
        {
            if (!wezly.Contains(wezel))
            {
                wezly.Add(wezel);
            }

            if (!wezly.Contains(krawedz))
            {
                wezly.Add(krawedz);
            }

            var temp = new Krawedz(waga, wezel, krawedz);

            if (!krawedzie.Contains(temp))
            {
                krawedzie.Add(temp);
            }
        }

        public void Dijkstra(Wezel start)
        {
            List<int> odleglosc = new List<int>();
            List<Wezel> poprzedni = new List<Wezel>();
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