using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisiProje
{
    public class Otobus : IUlasim
    {
        List<IUlasim> otobusListe;
        public Otobus()
        {
            otobusListe = DataSource.otobusListe;
        }

        public int ID { get; set; }
        public string Isim { get; set; }
        public decimal Ucret { get; set; }
        public DateTime seyehatBaslangic { get; set; }
        public DateTime seyehatBitis { get; set; }
        public bool iptalMi { get; set; }




        public List<IUlasim> enUcuzListele(DateTime seyehatBaslangic)
        {
            List<IUlasim> list = otobusListe;
            list = (from I in list where I.seyehatBaslangic.Date == seyehatBaslangic.Date select I).ToList();
            list = (from I in list orderby I.Ucret ascending select I).ToList();

            return list;

        }

        public bool iptalKontrol(int ID)
        {
            bool kontrol = false;
            List<IUlasim> list = otobusListe;
            foreach (IUlasim uList in list)
            {
                if (uList.ID == ID)
                {
                    kontrol = uList.iptalMi;
                    break;
                }

            }
            return kontrol;
        }
    }
}
