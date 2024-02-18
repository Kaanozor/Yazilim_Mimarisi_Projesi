using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimMimarisiProje
{
    public partial class giris_ekrani : Form
    {
        public static string Ulasimbilgi = "";
        public static string Konaklamabilgi = "";
        public giris_ekrani()
        {
            InitializeComponent();
        }

        private void btn_devamet_Click(object sender, EventArgs e)
        {
            Ulasimbilgi = ulasim.SelectedItem.ToString();
            Konaklamabilgi = konaklama.SelectedItem.ToString();
            Rezervasyon rezervasyon = new Rezervasyon();
            this.Hide();
            rezervasyon.Show();
        }
    }
}
