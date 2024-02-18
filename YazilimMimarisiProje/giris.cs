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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void giris_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rbotel rbotel = new rbotel();
            rbotel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rapor rapor = new Rapor();
            rapor.Show();
        }
    }
    }


   