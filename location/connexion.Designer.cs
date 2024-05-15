namespace location
{
    partial class connexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(connexion));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.Azure;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(201, 323);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(163, -31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(388, 267);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 19F, FontStyle.Bold);
            label1.ForeColor = Color.DarkSlateBlue;
            label1.Location = new Point(219, 9);
            label1.Name = "label1";
            label1.Size = new Size(291, 30);
            label1.TabIndex = 1;
            label1.Text = "formulaire de connexion";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(282, 207);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 29);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(282, 242);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 29);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // guna2Button1
            // 
            guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.DarkSlateBlue;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(317, 281);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(111, 30);
            guna2Button1.TabIndex = 4;
            guna2Button1.Text = "se connecter";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateBlue;
            label2.Location = new Point(207, 214);
            label2.Name = "label2";
            label2.Size = new Size(68, 16);
            label2.TabIndex = 5;
            label2.Text = "username";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateBlue;
            label3.Location = new Point(208, 249);
            label3.Name = "label3";
            label3.Size = new Size(67, 16);
            label3.TabIndex = 6;
            label3.Text = "password";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Lucida Sans Unicode", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Lavender;
            label4.Location = new Point(12, 110);
            label4.Name = "label4";
            label4.Size = new Size(85, 23);
            label4.TabIndex = 7;
            label4.Text = "securite";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Lucida Sans Unicode", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Lavender;
            label5.Location = new Point(34, 157);
            label5.Name = "label5";
            label5.Size = new Size(85, 23);
            label5.TabIndex = 8;
            label5.Text = "viabilite";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Lucida Sans Unicode", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Lavender;
            label6.Location = new Point(58, 197);
            label6.Name = "label6";
            label6.Size = new Size(128, 23);
            label6.TabIndex = 9;
            label6.Text = "disponibilite";
            // 
            // connexion
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 323);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(guna2Button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "connexion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "connexion";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}