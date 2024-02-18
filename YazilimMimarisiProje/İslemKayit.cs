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
  
    public partial class rbotel : Form
    {
        


        public rbotel()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            

            Musteri musteri = new Musteri();
            
            
            
            Seyehat ucakotelSeyahat = new Seyehat(new UcakOtel(),musteri);
            Seyehat ucakcadirSeyahat = new Seyehat(new UcakCadir(), musteri);
            Seyehat otobusotelSeyahat = new Seyehat(new OtobusOtel(), musteri);
            Seyehat otobuscadirSeyahat = new Seyehat(new OtobusCadir(), musteri);

            if (rbucak.Checked==true && radioButton3.Checked==true)
            {
                ucakotelSeyahat.GidisTarihi = dtpgidiş.Value;
                ucakotelSeyahat.DonusTarihi = dtpdönüş.Value;
                ucakotelSeyahat.FirmaAdi = cbFirma.Text;
                ucakotelSeyahat.Nereden = tbkalkış.Text.ToString();
                ucakotelSeyahat.Nereye = tbvarış.Text.ToString();
               

                ucakcadirSeyahat.SeyahatYap();

               
                
               

            }            
            else if (rbucak.Checked == true && rbcadır.Checked == true)
            {

                ucakcadirSeyahat.GidisTarihi = dtpgidiş.Value;
                ucakcadirSeyahat.DonusTarihi = dtpdönüş.Value;
                ucakcadirSeyahat.FirmaAdi = cbFirma.Text;
                ucakcadirSeyahat.Nereden = tbkalkış.Text.ToString();
                ucakcadirSeyahat.Nereye = tbvarış.Text.ToString();
             
                ucakcadirSeyahat.SeyahatYap();
              

            }  
            else if (rbotobus.Checked == true && radioButton3.Checked == true)
            {
                otobusotelSeyahat.GidisTarihi = dtpgidiş.Value;
                otobusotelSeyahat.DonusTarihi = dtpdönüş.Value;
                otobusotelSeyahat.FirmaAdi = cbFirma.Text;
                otobusotelSeyahat.Nereden = tbkalkış.Text.ToString();
                otobusotelSeyahat.Nereye = tbvarış.Text.ToString();
           
                ucakcadirSeyahat.SeyahatYap();


            }
            else if (rbotobus.Checked == true && rbcadır.Checked == true)
            {

                otobuscadirSeyahat.GidisTarihi = dtpgidiş.Value;
                otobuscadirSeyahat.DonusTarihi = dtpdönüş.Value;
                otobuscadirSeyahat.FirmaAdi = cbFirma.Text;
                otobuscadirSeyahat.Nereden = tbkalkış.Text.ToString();
                otobuscadirSeyahat.Nereye = tbvarış.Text.ToString();
                ucakcadirSeyahat.SeyahatYap();
            }
            else
            {
                MessageBox.Show("lütfen boş alanları doldurunuz.");
            }



            
          


        }

       
    }
}
