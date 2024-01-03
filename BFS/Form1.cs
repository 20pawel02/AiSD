//do zrobienia BFS https://en.wikipedia.org/wiki/Breadth-first_search najlepiej na liscie
//kolejka na liscie -> dodawac sasiadow ktorzy sa polaczoni z aktualnym wezlem i nie zostali jeszcze odwiedzeni

namespace BFS
{
    public partial class Form1 : Form
    {
        string napis = "";
        List<Wezel> odwiedzone = new List<Wezel>();
        Queue<Wezel> queue = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void BFS(Wezel wezel)
        {
            odwiedzone.Add(wezel);
            queue.Enqueue(wezel);

            while (queue.Count > 0)
            {
                var s = queue.Dequeue();
                foreach (var sasiad in s.sasiad)
                {
                    if (!odwiedzone.Contains(sasiad))
                    {
                        queue.Enqueue(sasiad);
                    }
                }
                if (queue.Count > 0)
                {
                    napis += s.wartosc.ToString() + " ";
                    odwiedzone.Add(queue.Peek());
                    s = queue.Peek();
                }
            }
        }





        public class Wezel
        {
            public int wartosc;
            public List<Wezel> sasiad = new List<Wezel>();

            public Wezel(int wartosc)
            {
                this.wartosc = wartosc;
            }

            public bool Add(Wezel s)
            {
                if (this == s)
                {
                    return false;
                }

                bool wynik = false;

                if (!this.sasiad.Contains(s))
                {
                    this.sasiad.Add(s);
                    wynik = true;
                }

                if (!s.sasiad.Contains(s))
                {
                    s.sasiad.Add(this);
                    wynik = true;
                }
                return wynik;
            }
        }

        
    }


}