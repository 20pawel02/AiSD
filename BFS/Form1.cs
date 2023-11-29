//do zrobienia BFS https://en.wikipedia.org/wiki/Breadth-first_search najlepiej na liscie
//kolejka na liscie -> dodawac sasiadow ktorzy sa polaczoni z aktualnym wezlem i nie zostali jeszcze odwiedzeni

namespace BFS
{
    public partial class Form1 : Form
    {
        string napis = "";
        
        public Form1()
        {
            InitializeComponent();
        }
        class Wezel
        {
            public Wezel root;
            public int loop_count = 0;

            public int value;
            public Wezel parent;

            public Wezel(int digit)
            {
                this.value = digit;
            }
        }
    }


}