using System.Reflection.Metadata.Ecma335;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        int[] bubbleSort(int[] array)
        {
            int temp = 0;
            bool sort = false;
            do
            {
                sort = false;

                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        sort = true;
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
            while (sort == true);
            return array;
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

        private void btn_BubbleSort(object sender, EventArgs e)
        {
            //int[] tab = { 4, 1, 3, 7, 5 };
            //MessageBox.Show(ToString(tab));
            //int[] tab_1 = bubbleSort(tab);
            //MessageBox.Show(ToString(tab_1));

            string liczby = tbInput.Text;
            int[] tablica = Covert(liczby);
            int[] tablica2 = bubbleSort(tablica);
            label2.Text = ("Wynik: " + ToString(tablica2));

        }

        private void lbl_wynik(object sender, EventArgs e)
        {

        }

        private void tbl_Input(object sender, EventArgs e)
        {

        }


    }
}