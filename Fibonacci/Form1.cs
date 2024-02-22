namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Class1> lista = new List<Class1>();
            for (int i = 0; i < 10; i++)
            {
                Button button = new Button();
                button.Top = i * 20;
                button.Text = Fibonacci(i).ToString();
                Controls.Add(button);
                Class1 újSor = new Class1();
                újSor.Érték = Fibonacci(i);
                újSor.Sorszám = i;
                lista.Add(újSor);
            }
            dataGridView1.DataSource = lista;
        }

        int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);

        }
    }
}