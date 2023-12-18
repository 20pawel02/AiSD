using System.Diagnostics;

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
            var x = drzewo.Nastepnik(drzewo.root.leweDziecko.praweDziecko);
            var y = drzewo.Poprzednik(drzewo.root.praweDziecko);
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

        public int IleDzieci()
        {
            int wynik = 0;
            if (this.leweDziecko != null)
            {
                wynik++;
            }
            if (this.praweDziecko != null)
            {
                wynik++;
            }
            return wynik;
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
            if (w.leweDziecko != null)
            {
                return this.ZnajdzNajwiekszy(w.praweDziecko);
            }
            while (w.rodzic != null)
            {
                if (w.rodzic.praweDziecko == w)
                {
                    return w.rodzic;
                }
                w = w.rodzic;
            }
            return null;
        }

        public Wezel Nastepnik(Wezel w)
        {
            if (w.praweDziecko != null)
            {
                return this.ZnajdzNajmniejszy(w.praweDziecko);
            }
            while (w.rodzic != null)
            {
                if (w.rodzic.leweDziecko == w)
                {
                    return w.rodzic;
                }
                w = w.rodzic;
            }
            return null;
        }

       

        Wezel UsunGdy0Dzieci(Wezel w)
        {
            if (w.rodzic == null)
            {
                this.root = null;
                return w;
            }

            if (w.rodzic.leweDziecko == w)
            {
                w.rodzic.leweDziecko = null;
            }
            else
            {
                w.rodzic.praweDziecko = null;
            }                

            w.rodzic = null;         
            return w;
        }

        Wezel UsunGdy1Dziecko(Wezel w)
        {
            Wezel dziecko = null;
            if (w.leweDziecko != null)
            {
                dziecko = w.leweDziecko;
                w.leweDziecko = null;
            }
            else
            {
                dziecko = w.praweDziecko;
                w.praweDziecko = null;
            }
            dziecko.rodzic = w.rodzic;
            if (w.rodzic.leweDziecko == w)
            {
                w.rodzic.leweDziecko = dziecko;
            }
            else
            {
                w.rodzic.praweDziecko = dziecko;
            }
            w.rodzic = null;
            return w;
        }

        Wezel UsunGdy2Dzieci(Wezel w)
        {
            var zamiennik = this.Nastepnik(w);
            zamiennik = this.Usun(zamiennik);

            if (w.rodzic != null)
            {
                if (w.rodzic.leweDziecko == w)
                {
                    w.rodzic.leweDziecko = zamiennik;
                }
                else
                {
                    w.rodzic.praweDziecko = zamiennik;
                }
            }
            zamiennik.rodzic = w.rodzic;

            w.rodzic = null;
            zamiennik.leweDziecko = w.leweDziecko;
            zamiennik.leweDziecko.rodzic = zamiennik;
            w.leweDziecko = null;

            zamiennik.praweDziecko = w.praweDziecko;
            zamiennik.praweDziecko.rodzic = zamiennik;
            w.praweDziecko = null;
            return w;
        }

        Wezel Usun(Wezel w)
        {
            var liczbaDzieci = w.IleDzieci();
            switch (liczbaDzieci)
            {
                case 0:
                    return this.UsunGdy0Dzieci(w);
                    break;
                case 1:
                    return this.UsunGdy1Dziecko(w);
                    break;
                case 2:
                    return this.UsunGdy2Dzieci(w);
                    break;
            }
            return w;
        }
    }

    public class Graf
    {
        List<Wezel> wezly;
    }
}