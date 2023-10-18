using System.Security.Policy;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        int[] sortArray(int[] array)
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
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
            while (sort);
            return array;
        }

        string ToString(int[] array)
        {
            string wynik = "";
            for (int i = 0; i < array.Length; i++)
            {
                wynik += array[i].ToString() + ", ";
            }
            return wynik;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] tab = { 4, 1, 3, 7, 5 };
            MessageBox.Show(ToString(tab));
            int[] tab_1 = sortArray(tab);
            MessageBox.Show(ToString(tab_1));
        }
    }
}