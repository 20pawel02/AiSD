using System.Diagnostics.Eventing.Reader;

namespace bubble_sort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void przycisk_start_Click(object sender, EventArgs e)
        {
            string liczby = tbInput.Text;
            int[] tablica = Covert(liczby);
            int[] tablica2 = BubbleSort(tablica);
            lbl_wynik.Text = ("Wynik: " + ToString(tablica2));
        }

        int[] BubbleSort(int[] tab)
        {
            int temp = tab[0];
            bool czyZmienna = false;

            do
            {
                czyZmienna = false;
                for (int i = 0; i < tab.Length - 1; i++)
                {
                    if (tab[i] > tab[i + 1])
                    {
                        czyZmienna = true;
                        temp = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = temp;
                    }
                }
            }
            while (czyZmienna == true);
            return tab;
        }

        string ToString(int[] array)
        {
            string wynik = "";
            for (int i = 0; i < array.Length; i++)
            {
                wynik += array[i].ToString() + " ";
            }
            return wynik;
        }

        int[] Covert(string napis)
        {
            var liczbyS = napis.Trim().Split(' ');
            int[] tablica = new int[liczbyS.Length];
            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = int.Parse(liczbyS[i]);
            }
            return tablica;

        }

        private void tbInput_Click(object sender, EventArgs e)
        {

        }
    }
}