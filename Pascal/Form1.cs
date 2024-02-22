namespace Pascal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int m = 40;
            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < sor + 1; oszlop++)
                {
                    Button button = new Button();
                    button.Width = m;
                    button.Height = m;
                    button.Left = m * oszlop + Width / 2;
                    button.Top = m * sor;
                    int x = Faktoriális(sor) / (Faktoriális(oszlop) * Faktoriális(sor - oszlop));
                    button.Text = x.ToString();
                    Controls.Add(button);
                }
            }
        }
        int Faktoriális(int n)
        {
            if (n == 0) return 1;
            return n * Faktoriális(n - 1);
        }


    }
}