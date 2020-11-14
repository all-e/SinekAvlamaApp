using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinekAvlamaApp
{
    public partial class frmOyun : Form
    {
        static int toplam = 0;
        static int sure = 30;
        Random rnd = new Random();

        public frmOyun()
        {
            InitializeComponent();
        }

        private void tmrButton_Tick(object sender, EventArgs e)
        {
            
            Button btn = new Button();
            btn.Size = new Size(100, 100);
            btn.Location = new Point(rnd.Next(this.ClientSize.Width - pnlGosterge.Width - btn.Width),rnd.Next(this.ClientSize.Height - btn.Height)); //form büyüdüğünde alan büyüyecek. clientsize borderları saymaz iç kısmı sayar.
            btn.Text = rnd.Next(100).ToString();
            btn.BackColor = Color.Transparent; //buton arkaplanı rengi
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.MouseOverBackColor = Color.Transparent;// mouse üzerine gelinceki rengi
            btn.FlatAppearance.MouseDownBackColor = Color.Transparent;// mouse tıkladığında ki rengi
            btn.FlatAppearance.BorderSize = 0; // buton çerçeve kalınlığı
            btn.BackgroundImage = imglist.Images[0]; //sinek resmimiz
            this.Controls.Add(btn);
            btn.Click += Btn_Click;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            toplam += int.Parse(btn.Text);
            lblSkor.Text = $"Skor:{toplam}";
            //btn.Visible = false; göstermez ama heapde durur.
            btn.Dispose(); //bir nesneyi heap bölgesinden atar.
            
        }

        private void frmOyun_Load(object sender, EventArgs e)
        {
            tmrButton.Start();
            tmrSure.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private static void FSYaz(string deger)
        {
            FileStream fs = new FileStream("skor.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(DateTime.Now +" ");
            sw.Write(deger +"\n");
            fs.Flush();
            sw.Close();
            fs.Close();
        }
        private void tmrSure_Tick(object sender, EventArgs e)
        {
            sure--;
            lblSure.Text = sure.ToString();
            if (sure == 0)
            {
                tmrSure.Stop();
                tmrButton.Stop();

                FSYaz(lblSkor.Text);

                DialogResult result = new DialogResult();

                result = MessageBox.Show($"Oyun sona erdi!\n{lblSkor.Text}","Tekrar denemelisin.",MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if(result == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }

        private void lblSure_Click(object sender, EventArgs e)
        {

        }
    }
}
