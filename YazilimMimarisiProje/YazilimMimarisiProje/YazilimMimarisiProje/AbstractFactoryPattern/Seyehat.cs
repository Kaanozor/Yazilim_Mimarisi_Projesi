
using System;
using System.Collections.Generic;

namespace YazilimMimarisiProje
{
    public class Seyehat
    {
        private AbstractFactrory abstractFactrory;
        private IUlasim ulasim;
        private IKonaklama konaklama;
        public Seyehat(AbstractFactrory abstractFactrory)
        {
            this.abstractFactrory = abstractFactrory;

            ulasim = abstractFactrory.CreateUlasim();
            konaklama = abstractFactrory.CreateKonaklama();
        }
        public bool iptalUlasimKontrol(int ulasimID)
        {
            ulasim.iptalMi = ulasim.iptalKontrol(ulasimID);

            return ulasim.iptalMi;
        }
        public bool iptalKonaklamaKontrol(int konaklamaID)
        {
            konaklama.iptalMi = konaklama.iptalKontrol(konaklamaID);

            return konaklama.iptalMi;
        }

        public List<IKonaklama> enucuzListeleKonaklama(DateTime seyatBaslangic)
        {
            return konaklama.enUcuzListele(seyatBaslangic);
        }

        public List<IUlasim> enucuzListeleUlasim(DateTime seyatBaslangic)
        {
            return ulasim.enUcuzListele(seyatBaslangic);
        }

    }
}

