using System;
using System.Collections.Generic;
using System.Linq;


namespace YazilimMimarisiProje
{
    public class Ucak : IUlasim
    {
        List<IUlasim> ucakListe;
        public Ucak()
        {
            ucakListe = DataSource.ucakListe;
        }


        public int ID { get; set; }
        public string Isim { get; set; }
        public decimal Ucret { get; set; }
        public DateTime seyehatBaslangic { get; set; }
        public DateTime seyehatBitis { get; set; }
        public bool iptalMi { get; set; }




        public List<IUlasim> enUcuzListele(DateTime seyehatBaslangic)
        {

            List<IUlasim> list = ucakListe;
            list = (from I in list where I.seyehatBaslangic.Date == seyehatBaslangic.Date select I).ToList();
            list = (from I in list orderby I.Ucret ascending select I).ToList();

            return list;
        }

        public bool iptalKontrol(int ID)
        {
            bool kontrol = false;
            List<IUlasim> list = ucakListe;
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
