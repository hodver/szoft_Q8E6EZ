namespace Adatkotes
{
    partial class FormCountryEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            hozzaad = new Button();
            terulet = new TextBox();
            bindingSource1 = new BindingSource(components);
            populacio = new TextBox();
            orszagnev = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            countryDataBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource).BeginInit();
            SuspendLayout();
            // 
            // hozzaad
            // 
            hozzaad.Location = new Point(161, 245);
            hozzaad.Name = "hozzaad";
            hozzaad.Size = new Size(75, 23);
            hozzaad.TabIndex = 0;
            hozzaad.Text = "&Ok";
            hozzaad.UseVisualStyleBackColor = true;
            // 
            // terulet
            // 
            terulet.DataBindings.Add(new Binding("Text", bindingSource1, "AreaInSquareKm", true));
            terulet.Location = new Point(12, 179);
            terulet.Name = "terulet";
            terulet.Size = new Size(224, 23);
            terulet.TabIndex = 1;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(CountryData);
            // 
            // populacio
            // 
            populacio.DataBindings.Add(new Binding("Text", bindingSource1, "Population", true));
            populacio.Location = new Point(12, 112);
            populacio.Name = "populacio";
            populacio.Size = new Size(224, 23);
            populacio.TabIndex = 2;
            // 
            // orszagnev
            // 
            orszagnev.DataBindings.Add(new Binding("Text", bindingSource1, "Name", true));
            orszagnev.Location = new Point(12, 52);
            orszagnev.Name = "orszagnev";
            orszagnev.Size = new Size(224, 23);
            orszagnev.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 4;
            label1.Text = "Country name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 94);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 5;
            label2.Text = "Population:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 161);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 6;
            label3.Text = "Area in km2:";
            // 
            // countryDataBindingSource
            // 
            countryDataBindingSource.DataSource = typeof(CountryData);
            // 
            // FormCountryEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 280);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(orszagnev);
            Controls.Add(populacio);
            Controls.Add(terulet);
            Controls.Add(hozzaad);
            Name = "FormCountryEdit";
            Text = "FormCountryEdit";
            Load += FormCountryEdit_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button hozzaad;
        private TextBox terulet;
        private TextBox populacio;
        private TextBox orszagnev;
        private BindingSource countryDataBindingSource;
        private Label label1;
        private Label label2;
        private Label label3;
        private BindingSource bindingSource1;
    }
}