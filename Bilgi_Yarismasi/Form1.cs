namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;


        private void button5_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;

            btnSonraki.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;


            soruno++;
            Lblsoruno.Text = soruno.ToString();




            if (soruno == 1)
            {
                richTextBox1.Text = "İyi Hissetmek kitabının yazarı kimdir? ";
                btnA.Text = "David Burns";
                btnB.Text = "Rosy Brown";
                btnC.Text = "Shakespeare";
                btnD.Text = "Fred Blackstone";

                Lbldgrcvp.Text = "David Burns";
            }

            if (soruno == 2)
            {
                richTextBox1.Text = "2022-2023 superlig sampiyonu kimdir ?";
                btnA.Text = "Başakşehir";
                btnB.Text = "Fenerbahçe";
                btnC.Text = "Galatasaray";
                btnD.Text = "Beşiktaş";

                Lbldgrcvp.Text = "Galatasaray";
            }

            if (soruno == 3)
            {
                richTextBox1.Text = "Mauro Icardi'nin 2023-2024 sezonu takım numarası kaçtır? ";
                btnA.Text = "10";
                btnB.Text = "99";
                btnC.Text = "7";
                btnD.Text = "9";

                Lbldgrcvp.Text = "9";

                btnSonraki.Text = "Sonuçlar";
            }

            if (soruno == 4)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;
                MessageBox.Show("Katıldığınız İçin Teşekkürler \n Doğru :" + dogru + " \n Yanlış : " + yanlis);
            }


        }

        private void btnA_Click(object sender, EventArgs e)
        {
            Lblvrlncvp.Text = btnA.Text;
            if (Lbldgrcvp.Text == Lblvrlncvp.Text)
            {
                dogru++;
                Lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                Lblyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            Lblvrlncvp.Text = btnB.Text;
            if (Lbldgrcvp.Text == Lblvrlncvp.Text)
            {
                dogru++;
                Lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                Lblyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            Lblvrlncvp.Text = btnC.Text;
            if (Lbldgrcvp.Text == Lblvrlncvp.Text)
            {
                dogru++;
                Lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                Lblyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            Lblvrlncvp.Text = btnD.Text;
            if (Lbldgrcvp.Text == Lblvrlncvp.Text)
            {
                dogru++;
                Lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                Lblyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            

        }
    }
}