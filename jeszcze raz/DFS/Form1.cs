using System.IO.Pipes;

namespace DFS
{
    public partial class Form1 : Form
    {
        string napis = "";
        List<Wezel2> odwiedzone = new List<Wezel2>();

        public Form1()
        {
            InitializeComponent();
        }

        class Wezel
        {
            public int wartossc;
            public List<Wezel> dzieci = new List<Wezel>();

            public Wezel(int liczba)
            {
                this.wartossc = liczba;
            }
        }

        void A(Wezel w)
        {
            for (int i = 0; i < w.dzieci.Count; i++)
            {
                A(w.dzieci[i]);
            }
            napis += " " + w.wartossc.ToString();
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

                if (!this.sasiedzi.Contains(this))
                {
                    this.sasiedzi.Add(this);
                    wynik = true;
                }
                return wynik;
            }
        }

        void B(Wezel2 w)
        {
            odwiedzone.Add(w);
            napis += w.wartosc.ToString() + " ";
            foreach (var sasiad in w.sasiedzi)
            {
                if (!odwiedzone.Contains(sasiad))
                {
                    B(sasiad);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var w1 = new Wezel(2);
            var w2 = new Wezel(8);
            var w3 = new Wezel(4);
            var w4 = new Wezel(10);
            var w5 = new Wezel(5);
            var w6 = new Wezel(3);
            var w7 = new Wezel(9);

            w1.dzieci.Add(w2);
            w1.dzieci.Add(w3);
            w2.dzieci.Add(w4);
            w2.dzieci.Add(w5);
            w3.dzieci.Add(w6);
            w5.dzieci.Add(w7);

            napis = "";
            A(w1);
            MessageBox.Show(napis);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var w1 = new Wezel2(1);
            var w2 = new Wezel2(2);
            var w3 = new Wezel2(3);
            var w4 = new Wezel2(4);
            var w5 = new Wezel2(5);
            var w6 = new Wezel2(6);
            var w7 = new Wezel2(7);

            w1.Add(w2);
            w1.Add(w3);
            w2.Add(w4);
            w4.Add(w5);
            w3.Add(w6);
            w3.Add(w7);
            napis = "";

            odwiedzone.Clear();

            B(w1);
            MessageBox.Show(napis);
        }
    }
}