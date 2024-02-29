namespace VillogoGomb
{
    public partial class Form1 : Form
    {
        //int méret = 40;  
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < 10; oszlop++)
                {
                    SzamoloGomb b = new SzamoloGomb();
                    b.Height = 20;
                    b.Width = 20;
                    b.Left = oszlop * 20;
                    b.Top = sor * 20;
                    //b.Text = ((sor + 1) * (oszlop + 1)).ToString();
                    Controls.Add(b);
                }
            }
        }
    }
}