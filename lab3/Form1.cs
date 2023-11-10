using OpenXmlPowerTools;

namespace lab3
{
    public partial class Form1 : Form
    {
        string napis = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button_start(object sender, EventArgs e)
        {
            wezel w1 = new wezel(5);
            A(w1);
            wezel w2 = new wezel(3);
            wezel w3 = new wezel(1);
            wezel w4 = new wezel(2);
            wezel w5 = new wezel(2);
            wezel w6 = new wezel(5);
            w1.dzieci.Add(w1);
            w2.dzieci.Add(w2);
            w3.dzieci.Add(w3);
            w4.dzieci.Add(w4);
            w5.dzieci.Add(w5);
            w6.dzieci.Add(w6);
        }

        void A(wezel w)
        {
            for (int i = 0; i < w.dzieci.Count; i++)
            {
                A(w.dzieci[i]);
            }
            napis += " " + w.wartosc.ToString();

            MessageBox.Show(napis);

        }
    }
    class wezel
    {
        public int wartosc;
        public List<wezel> dzieci = new List<wezel>(); // List<tablica> to taka dynamiczna tablica jak w c++

        public wezel(int liczba)
        {
            this.wartosc = liczba;
        }

    }
}