namespace Snake
{
    public partial class Form1 : Form
    {
        int fej_x = 100;
        int fej_y = 100;
        int ir�ny_x = 1;
        int ir�ny_y = 0;
        int l�p�ssz�m = 0;
        int hossz = 8;
        int dbF = 0;
        int dbP = 0;
        List<K�gy�Elem> k�gy� = new List<K�gy�Elem>();
        Random place = new Random();
        List<Food> kaja = new List<Food>();
        List<Poison> m�reg = new List<Poison>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            l�p�ssz�m++;
            dbF++;
            dbP++;

            //Fejn�veszt�s
            fej_x += ir�ny_x * K�gy�Elem.M�ret;
            fej_y += ir�ny_y * K�gy�Elem.M�ret;

            foreach (object item in Controls)
            {
                //Ha vannak m�r valami ott, ahova az �j fejet tenn�m, v�ge a j�t�knak
                if (item is K�gy�Elem)
                {
                    K�gy�Elem k = (K�gy�Elem)item;

                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
            }

            K�gy�Elem ke = new K�gy�Elem();
            ke.Top = fej_y;
            ke.Left = fej_x;
            k�gy�.Add(ke);
            Controls.Add(ke);

            //Farokv�g�s
            if (k�gy�.Count > hossz)
            {
                K�gy�Elem lev�gand� = k�gy�[0];
                k�gy�.RemoveAt(0);
                Controls.Remove(lev�gand�);
            }

            //if (l�p�ssz�m % 5 == 0) ++hossz;

            if (l�p�ssz�m % 2 == 0) ke.BackColor = Color.Yellow;

            int kaja_x = place.Next(100, 500);
            int kaja_y = place.Next(100, 500);
            int m�reg_x = place.Next(100, 500);
            int m�reg_y = place.Next(100, 500);

            Food food = new Food();
            food.Top = kaja_y;
            food.Left = kaja_x;
            kaja.Add(food);
            Controls.Add (food);

            if (dbF > 1) Controls.RemoveAt(0);

            Poison poison = new Poison();
            poison.Top = m�reg_y;
            poison.Left = m�reg_x;
            m�reg.Add(poison);
            Controls.Add(poison);

            if (dbP > 1) Controls.RemoveAt(0);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                ir�ny_y = -1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                ir�ny_y = 1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                ir�ny_y = 0;
                ir�ny_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                ir�ny_y = 0;
                ir�ny_x = 1;
            }
        }
    }
}