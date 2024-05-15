namespace location
{
    partial class chargement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chargement));
            panel1 = new Panel();
            label2 = new Label();
            guna2hScrollBar1 = new Guna.UI2.WinForms.Guna2HScrollBar();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(guna2hScrollBar1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkSlateBlue;
            label2.Font = new Font("Myanmar Text", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(371, 367);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 3;
            label2.Text = "chargement...";
            // 
            // guna2hScrollBar1
            // 
            guna2hScrollBar1.AutoRoundedCorners = true;
            guna2hScrollBar1.BorderRadius = 8;
            guna2hScrollBar1.InUpdate = false;
            guna2hScrollBar1.LargeChange = 10;
            guna2hScrollBar1.Location = new Point(104, 405);
            guna2hScrollBar1.Name = "guna2hScrollBar1";
            guna2hScrollBar1.ScrollbarSize = 18;
            guna2hScrollBar1.Size = new Size(623, 18);
            guna2hScrollBar1.TabIndex = 2;
            guna2hScrollBar1.ThumbColor = Color.DarkViolet;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSlateBlue;
            label1.Font = new Font("Times New Roman", 19F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(166, 25);
            label1.Name = "label1";
            label1.Size = new Size(529, 30);
            label1.TabIndex = 0;
            label1.Text = "application de gestion de  location de voitures";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(84, -7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(695, 445);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
            // 
            // chargement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "chargement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label label1;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HScrollBar guna2hScrollBar1;
        private Label label2;
    }
}
