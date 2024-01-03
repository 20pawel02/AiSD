namespace select_sort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            string tabs = tbInput.Text;
            int[] tab = ConvertToInt(tabs);
            int[] tab2 = SelectSort(tab);
            string wynik = ConvertToString(tab2);
            lbl_wynik.Text = wynik;
        }

        int[] SelectSort(int[] tab)
        {
            int temp, min;
            for (int i = 0; i <= tab.Length; i++)
            {
                min = i;
                for (int j = i; j < tab.Length; j++)
                {
                    if (tab[j] < tab[min])
                    {
                        min = j;
                    }
                    temp = tab[i];
                    tab[i] = tab[min];
                    tab[min] = temp;
                }
            }
            return tab;
        }

        int[] ConvertToInt(string napis)
        {
            var liczbyS = napis.Trim().Split(" ");
            int[] liczby = new int[liczbyS.Length];
            for (int i = 0; i < liczbyS.Length; i++)
            {
                liczby[i] = int.Parse(liczbyS[i]);
            }
            return liczby;
        }

        string ConvertToString(int[] tab)
        {
            string wynik = "";
            for (int i = 0; i < tab.Length; i++)
            {
                wynik += tab[i].ToString() + " ";
            }
            return wynik;
        }

        private void tbInput_Click(object sender, EventArgs e)
        {

        }

        private void lbl_wynik_Click(object sender, EventArgs e)
        {

        }
    }
}