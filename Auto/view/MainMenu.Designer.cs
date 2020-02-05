namespace Autokauppa.view
{
    partial class MainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kokeileYhteyttäToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MittariLukema = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tilavuus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Hinta = new System.Windows.Forms.TextBox();
            this.Merkki = new System.Windows.Forms.ComboBox();
            this.Malli = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.SeuraavaButton = new System.Windows.Forms.Button();
            this.EdellinenButton = new System.Windows.Forms.Button();
            this.UusiButton = new System.Windows.Forms.Button();
            this.TallennaButton = new System.Windows.Forms.Button();
            this.PoistaButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Vari = new System.Windows.Forms.ComboBox();
            this.Polttoaine = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(371, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fILEToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kokeileYhteyttäToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // kokeileYhteyttäToolStripMenuItem
            // 
            this.kokeileYhteyttäToolStripMenuItem.Name = "kokeileYhteyttäToolStripMenuItem";
            this.kokeileYhteyttäToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.kokeileYhteyttäToolStripMenuItem.Text = "Kokeile yhteyttä";
            this.kokeileYhteyttäToolStripMenuItem.Click += new System.EventHandler(this.kokeileYhteyttäToolStripMenuItem_Click);
            // 
            // MittariLukema
            // 
            this.MittariLukema.Location = new System.Drawing.Point(157, 118);
            this.MittariLukema.Name = "MittariLukema";
            this.MittariLukema.Size = new System.Drawing.Size(58, 20);
            this.MittariLukema.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(13, 121);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(69, 13);
            this.label.TabIndex = 2;
            this.label.Text = "Mittarilukema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Moottorin tilavuus";
            // 
            // Tilavuus
            // 
            this.Tilavuus.Location = new System.Drawing.Point(157, 144);
            this.Tilavuus.Name = "Tilavuus";
            this.Tilavuus.Size = new System.Drawing.Size(58, 20);
            this.Tilavuus.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hinta";
            // 
            // Hinta
            // 
            this.Hinta.Location = new System.Drawing.Point(157, 170);
            this.Hinta.Name = "Hinta";
            this.Hinta.Size = new System.Drawing.Size(58, 20);
            this.Hinta.TabIndex = 5;
            // 
            // Merkki
            // 
            this.Merkki.FormattingEnabled = true;
            this.Merkki.Location = new System.Drawing.Point(13, 44);
            this.Merkki.Name = "Merkki";
            this.Merkki.Size = new System.Drawing.Size(121, 21);
            this.Merkki.TabIndex = 7;
            this.Merkki.SelectedIndexChanged += new System.EventHandler(this.Merkki_SelectedIndexChanged);
            // 
            // Malli
            // 
            this.Malli.FormattingEnabled = true;
            this.Malli.Location = new System.Drawing.Point(154, 44);
            this.Malli.Name = "Malli";
            this.Malli.Size = new System.Drawing.Size(121, 21);
            this.Malli.TabIndex = 8;
            this.Malli.Enter += new System.EventHandler(this.Malli_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Merkki";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Malli";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 233);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Rekisteröintipäivämäärä";
            // 
            // SeuraavaButton
            // 
            this.SeuraavaButton.Location = new System.Drawing.Point(284, 273);
            this.SeuraavaButton.Name = "SeuraavaButton";
            this.SeuraavaButton.Size = new System.Drawing.Size(75, 23);
            this.SeuraavaButton.TabIndex = 13;
            this.SeuraavaButton.Text = "Seuraava";
            this.SeuraavaButton.UseVisualStyleBackColor = true;
            this.SeuraavaButton.Click += new System.EventHandler(this.SeuraavaButton_Click);
            // 
            // EdellinenButton
            // 
            this.EdellinenButton.Location = new System.Drawing.Point(12, 273);
            this.EdellinenButton.Name = "EdellinenButton";
            this.EdellinenButton.Size = new System.Drawing.Size(75, 23);
            this.EdellinenButton.TabIndex = 14;
            this.EdellinenButton.Text = "Edellinen";
            this.EdellinenButton.UseVisualStyleBackColor = true;
            this.EdellinenButton.Click += new System.EventHandler(this.EdellinenButton_Click);
            // 
            // UusiButton
            // 
            this.UusiButton.Location = new System.Drawing.Point(284, 137);
            this.UusiButton.Name = "UusiButton";
            this.UusiButton.Size = new System.Drawing.Size(75, 23);
            this.UusiButton.TabIndex = 15;
            this.UusiButton.Text = "Uusi tietue";
            this.UusiButton.UseVisualStyleBackColor = true;
            this.UusiButton.Click += new System.EventHandler(this.UusiButton_Click);
            // 
            // TallennaButton
            // 
            this.TallennaButton.Location = new System.Drawing.Point(106, 273);
            this.TallennaButton.Name = "TallennaButton";
            this.TallennaButton.Size = new System.Drawing.Size(75, 23);
            this.TallennaButton.TabIndex = 16;
            this.TallennaButton.Text = "Tallena";
            this.TallennaButton.UseVisualStyleBackColor = true;
            this.TallennaButton.Click += new System.EventHandler(this.TallennaButton_Click);
            // 
            // PoistaButton
            // 
            this.PoistaButton.Location = new System.Drawing.Point(187, 273);
            this.PoistaButton.Name = "PoistaButton";
            this.PoistaButton.Size = new System.Drawing.Size(75, 23);
            this.PoistaButton.TabIndex = 17;
            this.PoistaButton.Text = "Poista";
            this.PoistaButton.UseVisualStyleBackColor = true;
            this.PoistaButton.Click += new System.EventHandler(this.PoistaButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Väri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Polttoaine";
            // 
            // Vari
            // 
            this.Vari.FormattingEnabled = true;
            this.Vari.Location = new System.Drawing.Point(154, 91);
            this.Vari.Name = "Vari";
            this.Vari.Size = new System.Drawing.Size(121, 21);
            this.Vari.TabIndex = 19;
            // 
            // Polttoaine
            // 
            this.Polttoaine.FormattingEnabled = true;
            this.Polttoaine.Location = new System.Drawing.Point(13, 91);
            this.Polttoaine.Name = "Polttoaine";
            this.Polttoaine.Size = new System.Drawing.Size(121, 21);
            this.Polttoaine.TabIndex = 18;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 307);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Vari);
            this.Controls.Add(this.Polttoaine);
            this.Controls.Add(this.PoistaButton);
            this.Controls.Add(this.TallennaButton);
            this.Controls.Add(this.UusiButton);
            this.Controls.Add(this.EdellinenButton);
            this.Controls.Add(this.SeuraavaButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Malli);
            this.Controls.Add(this.Merkki);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Hinta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tilavuus);
            this.Controls.Add(this.label);
            this.Controls.Add(this.MittariLukema);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kokeileYhteyttäToolStripMenuItem;
        private System.Windows.Forms.TextBox MittariLukema;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tilavuus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Hinta;
        private System.Windows.Forms.ComboBox Merkki;
        private System.Windows.Forms.ComboBox Malli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SeuraavaButton;
        private System.Windows.Forms.Button EdellinenButton;
        private System.Windows.Forms.Button UusiButton;
        private System.Windows.Forms.Button TallennaButton;
        private System.Windows.Forms.Button PoistaButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Vari;
        private System.Windows.Forms.ComboBox Polttoaine;
    }
}