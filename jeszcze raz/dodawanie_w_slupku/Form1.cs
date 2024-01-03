namespace dodawanie_w_slupku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            int a1 = (int)nud_A.Value;
            int b2 = (int)nud_B.Value;
            string wynik = sumak(a1, b2);
            MessageBox.Show(wynik);
        }

        string sumak(int a, int b)
        {
            string aa = a.ToString();
            string bb = b.ToString();
            int maxLen = Math.Max(aa.Length, bb.Length);
            int next = 0;
            string wynik = "";
            for(int i = 0; i < maxLen; i++)
            {
                int cyfra1 = 0;
                int cyfra2 = 0;
                if(i < aa.Length)
                {
                    cyfra1 = aa[aa.Length - 1 - i] - '0';
                }
                if(i < bb.Length)
                {
                    cyfra2 = bb[bb.Length - 1 - i] - '0';
                }

                int suma = cyfra1 + cyfra2 + next;
                next = suma / 10;
                if (aa.Length > 1 || bb.Length > 1)
                {
                    if (i == maxLen - 1)
                    {
                        wynik = suma + wynik;
                    }

                    else
                    {
                        wynik = (suma % 10) + wynik;
                    }
                }
                else
                {
                    wynik = suma.ToString();
                }
            }
            return wynik;
        }     
    }
}