namespace Bilgi_Yarismasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            btnA = new Button();
            btnB = new Button();
            btnC = new Button();
            btnD = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Lblsoruno = new Label();
            Lbldogru = new Label();
            Lblyanlis = new Label();
            btnSonraki = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            Lbldgrcvp = new Label();
            Lblvrlncvp = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(26, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(560, 267);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // btnA
            // 
            btnA.Location = new Point(43, 296);
            btnA.Name = "btnA";
            btnA.Size = new Size(196, 52);
            btnA.TabIndex = 1;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = true;
            btnA.Click += btnA_Click;
            // 
            // btnB
            // 
            btnB.Location = new Point(309, 296);
            btnB.Name = "btnB";
            btnB.Size = new Size(196, 52);
            btnB.TabIndex = 2;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = true;
            btnB.Click += btnB_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(43, 373);
            btnC.Name = "btnC";
            btnC.Size = new Size(196, 52);
            btnC.TabIndex = 3;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnD
            // 
            btnD.Location = new Point(309, 373);
            btnD.Name = "btnD";
            btnD.Size = new Size(196, 52);
            btnD.TabIndex = 4;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = true;
            btnD.Click += btnD_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(748, 58);
            label1.Name = "label1";
            label1.Size = new Size(120, 29);
            label1.TabIndex = 5;
            label1.Text = "Soru No : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(748, 105);
            label2.Name = "label2";
            label2.Size = new Size(97, 29);
            label2.TabIndex = 6;
            label2.Text = "Doğru : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(748, 154);
            label3.Name = "label3";
            label3.Size = new Size(97, 29);
            label3.TabIndex = 7;
            label3.Text = "Yanlış : ";
            // 
            // Lblsoruno
            // 
            Lblsoruno.AutoSize = true;
            Lblsoruno.Location = new Point(866, 58);
            Lblsoruno.Name = "Lblsoruno";
            Lblsoruno.Size = new Size(26, 29);
            Lblsoruno.TabIndex = 8;
            Lblsoruno.Text = "0";
            // 
            // Lbldogru
            // 
            Lbldogru.AutoSize = true;
            Lbldogru.Location = new Point(866, 105);
            Lbldogru.Name = "Lbldogru";
            Lbldogru.Size = new Size(26, 29);
            Lbldogru.TabIndex = 9;
            Lbldogru.Text = "0";
            // 
            // Lblyanlis
            // 
            Lblyanlis.AutoSize = true;
            Lblyanlis.Location = new Point(866, 154);
            Lblyanlis.Name = "Lblyanlis";
            Lblyanlis.Size = new Size(26, 29);
            Lblyanlis.TabIndex = 10;
            Lblyanlis.Text = "0";
            // 
            // btnSonraki
            // 
            btnSonraki.Location = new Point(728, 205);
            btnSonraki.Name = "btnSonraki";
            btnSonraki.Size = new Size(181, 46);
            btnSonraki.TabIndex = 11;
            btnSonraki.Text = "Sonraki";
            btnSonraki.UseVisualStyleBackColor = true;
            btnSonraki.Click += button5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(653, 307);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(820, 307);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(133, 107);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // Lbldgrcvp
            // 
            Lbldgrcvp.AutoSize = true;
            Lbldgrcvp.Location = new Point(534, 461);
            Lbldgrcvp.Name = "Lbldgrcvp";
            Lbldgrcvp.Size = new Size(119, 29);
            Lbldgrcvp.TabIndex = 14;
            Lbldgrcvp.Text = "Lbldgrcvp";
            Lbldgrcvp.Visible = false;
            // 
            // Lblvrlncvp
            // 
            Lblvrlncvp.AutoSize = true;
            Lblvrlncvp.Location = new Point(664, 461);
            Lblvrlncvp.Name = "Lblvrlncvp";
            Lblvrlncvp.Size = new Size(125, 29);
            Lblvrlncvp.TabIndex = 15;
            Lblvrlncvp.Text = "Lblynlscvp";
            Lblvrlncvp.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 501);
            Controls.Add(Lblvrlncvp);
            Controls.Add(Lbldgrcvp);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnSonraki);
            Controls.Add(Lblyanlis);
            Controls.Add(Lbldogru);
            Controls.Add(Lblsoruno);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnD);
            Controls.Add(btnC);
            Controls.Add(btnB);
            Controls.Add(btnA);
            Controls.Add(richTextBox1);
            Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btnA;
        private Button btnB;
        private Button btnC;
        private Button btnD;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label Lblsoruno;
        private Label Lbldogru;
        private Label Lblyanlis;
        private Button btnSonraki;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label Lbldgrcvp;
        private Label Lblvrlncvp;
    }
}