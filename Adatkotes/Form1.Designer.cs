namespace Adatkotes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            megnyitas = new Button();
            torles = new Button();
            szerkesztes = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(739, 349);
            dataGridView1.TabIndex = 0;
            // 
            // megnyitas
            // 
            megnyitas.Location = new Point(681, 27);
            megnyitas.Name = "megnyitas";
            megnyitas.Size = new Size(75, 23);
            megnyitas.TabIndex = 1;
            megnyitas.Text = "Megnyitás";
            megnyitas.UseVisualStyleBackColor = true;
            megnyitas.Click += megnyitas_Click;
            // 
            // torles
            // 
            torles.Location = new Point(613, 420);
            torles.Name = "torles";
            torles.Size = new Size(75, 23);
            torles.TabIndex = 2;
            torles.Text = "Törlés";
            torles.UseVisualStyleBackColor = true;
            // 
            // szerkesztes
            // 
            szerkesztes.Location = new Point(692, 420);
            szerkesztes.Name = "szerkesztes";
            szerkesztes.Size = new Size(75, 23);
            szerkesztes.TabIndex = 3;
            szerkesztes.Text = "Szerkesztés";
            szerkesztes.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(szerkesztes);
            Controls.Add(torles);
            Controls.Add(megnyitas);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button megnyitas;
        private Button torles;
        private Button szerkesztes;
    }
}