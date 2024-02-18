using System;
using System.Windows.Forms;

namespace YazilimMimarisiProje
{
    public partial class Rezervasyon : Form
    {
        public Rezervasyon()
        {
            InitializeComponent();
        }

        private void Rezervasyon_Load(object sender, EventArgs e)
        {
            lbl_ulasim.Text = giris_ekrani.Ulasimbilgi.ToString();
            lbl_konaklama.Text = giris_ekrani.Konaklamabilgi.ToString();  
            for(int i = 1; i < 41; i++)
            {
                comboBox1.Items.Add(i);
            }
        }

        private void btn_rezeervasyonolustur_Click(object sender, EventArgs e)
        {
           
        }
    }
}
