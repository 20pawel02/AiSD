namespace drzewo_binarne
{
    public partial class Form1 : Form
    {
        string napis = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            var w1 = new Wezel(2);
            var drzewo = new DrzewoBinarne(w1);
            drzewo.Add(2);
            drzewo.Add(1);
            drzewo.Add(3);
            drzewo.Add(7);
            drzewo.Add(6);
            drzewo.Add(9);
            var x = drzewo.Poprzednik(drzewo.root.praweDziecko);
        }
    }

    public class Wezel
    {
        public int wartosc;
        public Wezel rodzic;
        public Wezel leweDziecko;
        public Wezel praweDziecko;
        
        public Wezel(int liczba)
        {
            this.wartosc = liczba;
        }

        public void Add(int liczba)
        {
            var dziecko = new Wezel(liczba);
            dziecko.rodzic = this;
            if (this.wartosc > liczba)
            {
                this.praweDziecko = dziecko;
            }
            else
            {
                this.leweDziecko = dziecko;
            }
        }
    }

    public class DrzewoBinarne
    {
        public Wezel root;
        int liczba_wezlow = 0;
        public DrzewoBinarne(Wezel root)
        {
            this.root = root;
        }   
         public void Add(int liczba)
        {
            if(root == null)
            {
                root = new Wezel(liczba);
                return;
            }
            var rodzic = this.ZnajdzRodzica(liczba);
            rodzic.Add(liczba);
            liczba_wezlow++;
        }

        public Wezel ZnajdzRodzica(int liczba)
        {
            var w = this.root;
            while (true)
            {
                if(liczba < w.wartosc)
                {
                    if(w.leweDziecko != null)
                    {
                        w = w.leweDziecko;
                    }
                    else
                    {
                        return w;
                    }
                }
                else
                {
                    if(w.praweDziecko != null)
                    {
                        w = w.praweDziecko;
                    }
                    else
                    {
                        return w;
                    }
                }
            }
        }

        public Wezel ZnajdzNajmniejszy(Wezel b)
        {
            var w = b;
            while (w.leweDziecko != null)
            {
                w = w.leweDziecko;
            }
            return w;
        }

        public Wezel ZnajdzNajwiekszy(Wezel b)
        {
            var w = b;
            while(w.praweDziecko != null)
            {
                w = w.praweDziecko;
            }
            return w;
        }

        public Wezel Znajdz(int liczba)
        {
            var w = this.root;
            if (w.wartosc == liczba)
            {
                return w;
            }

            while (true)
            {
                if (liczba < w.wartosc)
                {
                    if (w.leweDziecko != null)
                    {
                        w = w.leweDziecko;
                        if(w.wartosc == liczba)
                        {
                            return w;
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    if (w.praweDziecko != null)
                    {
                        w = w.praweDziecko;
                        if(w.wartosc == liczba)
                        {
                            return w;
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public Wezel Poprzednik(Wezel w)
        {
            if(w.leweDziecko != null)
            {
                return this.ZnajdzNajwiekszy(w.leweDziecko);
            }
            if (w.rodzic == null)
            {
                return null;
            }
            while(w == w.rodzic.leweDziecko)
            {
                w = w.rodzic;
                if(w.rodzic == null)
                {
                    return null;
                }
                return w.rodzic;
            }
        }

        public Wezel Nastepnik(Wezel w)
        {
            if (w.praweDziecko != null)
            {
                return this.ZnajdzNajmniejszy(w.praweDziecko);
            }
            if (w.rodzic == null)
            {
                return null;
            }
            while(w.rodzic != null)
            {
                
            }
        }
        
        public Wezel Usun(Wezel w)
        {
            // 1) Gdy nie ma dzieci to odwiazujemy wezel
            // 2) Gdy jest 1 dziecko to wchodzi na miejsce rodzica
            // 3) Gdy 2 dzieci 
        }
    }
}