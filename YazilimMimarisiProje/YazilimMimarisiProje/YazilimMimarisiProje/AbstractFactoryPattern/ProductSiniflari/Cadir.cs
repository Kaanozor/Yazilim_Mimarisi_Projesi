using System;
using System.Collections.Generic;
using System.Linq;

namespace YazilimMimarisiProje
{
    public class Cadir : IKonaklama
    {
        List<IKonaklama> cadirListe;
        public Cadir()
        {
            cadirListe = DataSource.cadirListe;
        }


        public int ID { get; set; }
        public string Isim { get; set; }
        public decimal Ucret { get; set; }
        public DateTime seyehatBaslangic { get; set; }
        public DateTime seyehatBitis { get; set; }
        public bool iptalMi { get; set; }


        public List<IKonaklama> enUcuzListele(DateTime seyehatBaslangic)
        {
            List<IKonaklama> list = cadirListe;
            list = (from I in list where I.seyehatBaslangic.Date == seyehatBaslangic.Date select I).ToList();
            list = (from I in list orderby I.Ucret ascending select I).ToList();

            return list;

        }

        public bool iptalKontrol(int ID)
        {
            bool kontrol = false;
            List<IKonaklama> list = cadirListe;
            foreach (IKonaklama kList in list)
            {
                if (kList.ID == ID)
                {
                    kontrol = kList.iptalMi;
                    break;
                }

            }
            return kontrol;
        }
    }
}
