using System.Collections;

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

            void BFS(Wezel w)
            {
                odwiedzone.Add(w);
                queue.Enqueue(w);

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

                    if (queue.Count < 0)
                    {
                        napis += s.wartosc.ToString() + " ";
                        odwiedzone.Add(queue.Peek());
                        s = queue.Peek();
                    }
                }
            }
        }

        

        private void button_start_Click(object sender, EventArgs e)
        {
            var w1 = new Wezel(1);
            var w2 = new Wezel(3);
            var w3 = new Wezel(5);
            var w4 = new Wezel(7);
            var w5 = new Wezel(9);
            var w6 = new Wezel(11);
            var w7 = new Wezel(13);
            var w8 = new Wezel(15);
            var w9 = new Wezel(17);

            w1.Add(w2);
            w1.Add(w3);
            w3.Add(w4);
            w3.Add(w5);
            w2.Add(w6);
            w2.Add(w7);
            w7.Add(w8);
            w8.Add(w9);

            odwiedzone.Clear();
            queue.Clear();
            BFS(w1);
            MessageBox.Show(napis);
        }
    }
}