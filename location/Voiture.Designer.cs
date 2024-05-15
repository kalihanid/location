namespace location
{
    partial class Voiture
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            plaquetb = new TextBox();
            label4 = new Label();
            marquetb = new ComboBox();
            label5 = new Label();
            modeletb = new TextBox();
            statuttb = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            prixtb = new TextBox();
            modifiertb = new Guna.UI2.WinForms.Guna2Button();
            enregistrertb = new Guna.UI2.WinForms.Guna2Button();
            supprimertb = new Guna.UI2.WinForms.Guna2Button();
            label8 = new Label();
            Voitureliste = new DataGridView();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Voitureliste).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1129, 58);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(346, 9);
            label3.Name = "label3";
            label3.Size = new Size(309, 31);
            label3.TabIndex = 3;
            label3.Text = "visualisation des voitures ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateBlue;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 717);
            panel2.Name = "panel2";
            panel2.Size = new Size(1129, 33);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkSlateBlue;
            label2.Font = new Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(346, 0);
            label2.Name = "label2";
            label2.Size = new Size(255, 36);
            label2.TabIndex = 2;
            label2.Text = "developpe par AMINE HANID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateBlue;
            label1.Location = new Point(46, 132);
            label1.Name = "label1";
            label1.Size = new Size(120, 16);
            label1.TabIndex = 7;
            label1.Text = "numero de plaque";
            label1.Click += label1_Click;
            // 
            // plaquetb
            // 
            plaquetb.Location = new Point(21, 161);
            plaquetb.Name = "plaquetb";
            plaquetb.Size = new Size(180, 23);
            plaquetb.TabIndex = 6;
            plaquetb.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkSlateBlue;
            label4.Location = new Point(265, 132);
            label4.Name = "label4";
            label4.Size = new Size(54, 16);
            label4.TabIndex = 8;
            label4.Text = "marque";
            // 
            // marquetb
            // 
            marquetb.FormattingEnabled = true;
            marquetb.Items.AddRange(new object[] { "toyota", "audi", "bmw", "mercedes", "dacia" });
            marquetb.Location = new Point(240, 161);
            marquetb.Name = "marquetb";
            marquetb.Size = new Size(121, 23);
            marquetb.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkSlateBlue;
            label5.Location = new Point(428, 132);
            label5.Name = "label5";
            label5.Size = new Size(53, 16);
            label5.TabIndex = 11;
            label5.Text = "modele";
            // 
            // modeletb
            // 
            modeletb.Location = new Point(401, 161);
            modeletb.Name = "modeletb";
            modeletb.Size = new Size(180, 23);
            modeletb.TabIndex = 10;
            // 
            // statuttb
            // 
            statuttb.FormattingEnabled = true;
            statuttb.Items.AddRange(new object[] { "prix", "dispo" });
            statuttb.Location = new Point(603, 161);
            statuttb.Name = "statuttb";
            statuttb.Size = new Size(121, 23);
            statuttb.TabIndex = 13;
            statuttb.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkSlateBlue;
            label6.Location = new Point(628, 132);
            label6.Name = "label6";
            label6.Size = new Size(44, 16);
            label6.TabIndex = 12;
            label6.Text = "statut";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkSlateBlue;
            label7.Location = new Point(797, 132);
            label7.Name = "label7";
            label7.Size = new Size(36, 16);
            label7.TabIndex = 15;
            label7.Text = "prix ";
            // 
            // prixtb
            // 
            prixtb.Location = new Point(770, 161);
            prixtb.Name = "prixtb";
            prixtb.Size = new Size(180, 23);
            prixtb.TabIndex = 14;
            // 
            // modifiertb
            // 
            modifiertb.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            modifiertb.CustomizableEdges = customizableEdges7;
            modifiertb.DisabledState.BorderColor = Color.DarkGray;
            modifiertb.DisabledState.CustomBorderColor = Color.DarkGray;
            modifiertb.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            modifiertb.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            modifiertb.FillColor = Color.DarkSlateBlue;
            modifiertb.Font = new Font("Segoe UI", 9F);
            modifiertb.ForeColor = Color.White;
            modifiertb.Location = new Point(286, 250);
            modifiertb.Name = "modifiertb";
            modifiertb.ShadowDecoration.CustomizableEdges = customizableEdges8;
            modifiertb.Size = new Size(111, 30);
            modifiertb.TabIndex = 16;
            modifiertb.Text = "modifier";
            // 
            // enregistrertb
            // 
            enregistrertb.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            enregistrertb.CustomizableEdges = customizableEdges9;
            enregistrertb.DisabledState.BorderColor = Color.DarkGray;
            enregistrertb.DisabledState.CustomBorderColor = Color.DarkGray;
            enregistrertb.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            enregistrertb.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            enregistrertb.FillColor = Color.DarkSlateBlue;
            enregistrertb.Font = new Font("Segoe UI", 9F);
            enregistrertb.ForeColor = Color.White;
            enregistrertb.Location = new Point(470, 250);
            enregistrertb.Name = "enregistrertb";
            enregistrertb.ShadowDecoration.CustomizableEdges = customizableEdges10;
            enregistrertb.Size = new Size(111, 30);
            enregistrertb.TabIndex = 17;
            enregistrertb.Text = "enregistrer";
            enregistrertb.Click += enregistrertb_Click;
            // 
            // supprimertb
            // 
            supprimertb.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            supprimertb.CustomizableEdges = customizableEdges11;
            supprimertb.DisabledState.BorderColor = Color.DarkGray;
            supprimertb.DisabledState.CustomBorderColor = Color.DarkGray;
            supprimertb.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            supprimertb.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            supprimertb.FillColor = Color.DarkSlateBlue;
            supprimertb.Font = new Font("Segoe UI", 9F);
            supprimertb.ForeColor = Color.White;
            supprimertb.Location = new Point(651, 250);
            supprimertb.Name = "supprimertb";
            supprimertb.ShadowDecoration.CustomizableEdges = customizableEdges12;
            supprimertb.Size = new Size(111, 30);
            supprimertb.TabIndex = 18;
            supprimertb.Text = "supprimer";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Times New Roman", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkSlateBlue;
            label8.ImageAlign = ContentAlignment.TopCenter;
            label8.Location = new Point(410, 338);
            label8.Name = "label8";
            label8.Size = new Size(191, 31);
            label8.TabIndex = 4;
            label8.Text = "list des voitures";
            label8.Click += label8_Click;
            // 
            // Voitureliste
            // 
            Voitureliste.BackgroundColor = Color.DarkSlateBlue;
            Voitureliste.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Voitureliste.Location = new Point(12, 372);
            Voitureliste.Name = "Voitureliste";
            Voitureliste.Size = new Size(1041, 258);
            Voitureliste.TabIndex = 19;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = this;
            // 
            // Voiture
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1129, 750);
            Controls.Add(Voitureliste);
            Controls.Add(label8);
            Controls.Add(supprimertb);
            Controls.Add(enregistrertb);
            Controls.Add(modifiertb);
            Controls.Add(label7);
            Controls.Add(prixtb);
            Controls.Add(statuttb);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(modeletb);
            Controls.Add(marquetb);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(plaquetb);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Voiture";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Voiture_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Voitureliste).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private TextBox plaquetb;
        private Label label4;
        private ComboBox marquetb;
        private Label label5;
        private TextBox modeletb;
        private ComboBox statuttb;
        private Label label6;
        private Label label7;
        private TextBox prixtb;
        private Guna.UI2.WinForms.Guna2Button modifiertb;
        private Guna.UI2.WinForms.Guna2Button enregistrertb;
        private Guna.UI2.WinForms.Guna2Button supprimertb;
        private Label label8;
        private DataGridView Voitureliste;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}