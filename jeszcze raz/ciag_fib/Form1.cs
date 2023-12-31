namespace ciag_fib
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            long intTemp = (long)nudNumberN.Value;
            MessageBox.Show(intTemp + " number of Fibonacci sequence is: " + fib2(intTemp));

        }

        long fib(long n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            return fib(n - 1) + fib(n - 2);
        }

        long fib2(long n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }

            long[] a = new long[n + 1];
            a[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                a[i] = a[i - 1] + a[i - 2];

            }
            return a[n];
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}