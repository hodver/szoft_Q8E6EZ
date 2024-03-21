namespace Snake
{
    public partial class Form1 : Form
    {
        int fej_x = 100;
        int fej_y = 100;
        int irány_x = 1;
        int irány_y = 0;
        int lépésszám = 0;
        int hossz = 8;
        int dbF = 0;
        int dbP = 0;
        List<KígyóElem> kígyó = new List<KígyóElem>();
        Random place = new Random();
        List<Food> kaja = new List<Food>();
        List<Poison> méreg = new List<Poison>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lépésszám++;
            dbF++;
            dbP++;

            //Fejnövesztés
            fej_x += irány_x * KígyóElem.Méret;
            fej_y += irány_y * KígyóElem.Méret;

            foreach (object item in Controls)
            {
                //Ha vannak már valami ott, ahova az új fejet tenném, vége a játéknak
                if (item is KígyóElem)
                {
                    KígyóElem k = (KígyóElem)item;

                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
            }

            KígyóElem ke = new KígyóElem();
            ke.Top = fej_y;
            ke.Left = fej_x;
            kígyó.Add(ke);
            Controls.Add(ke);

            //Farokvágás
            if (kígyó.Count > hossz)
            {
                KígyóElem levágandó = kígyó[0];
                kígyó.RemoveAt(0);
                Controls.Remove(levágandó);
            }

            //if (lépésszám % 5 == 0) ++hossz;

            if (lépésszám % 2 == 0) ke.BackColor = Color.Yellow;

            int kaja_x = place.Next(100, 500);
            int kaja_y = place.Next(100, 500);
            int méreg_x = place.Next(100, 500);
            int méreg_y = place.Next(100, 500);

            Food food = new Food();
            food.Top = kaja_y;
            food.Left = kaja_x;
            kaja.Add(food);
            Controls.Add (food);

            if (dbF > 1) Controls.RemoveAt(0);

            Poison poison = new Poison();
            poison.Top = méreg_y;
            poison.Left = méreg_x;
            méreg.Add(poison);
            Controls.Add(poison);

            if (dbP > 1) Controls.RemoveAt(0);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                irány_y = -1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                irány_y = 1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                irány_y = 0;
                irány_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                irány_y = 0;
                irány_x = 1;
            }
        }
    }
}