namespace Snake
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
            components = new System.ComponentModel.Container();
            kígyóElem1 = new KígyóElem();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)kígyóElem1).BeginInit();
            SuspendLayout();
            // 
            // kígyóElem1
            // 
            kígyóElem1.BackColor = Color.Fuchsia;
            kígyóElem1.Location = new Point(121, 92);
            kígyóElem1.Name = "kígyóElem1";
            kígyóElem1.Size = new Size(20, 20);
            kígyóElem1.TabIndex = 0;
            kígyóElem1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(kígyóElem1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)kígyóElem1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private KígyóElem kígyóElem1;
        private System.Windows.Forms.Timer timer1;
    }
}