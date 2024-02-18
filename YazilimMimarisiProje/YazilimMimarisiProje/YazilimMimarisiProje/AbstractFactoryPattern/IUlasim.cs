using System;
using System.Collections.Generic;

namespace YazilimMimarisiProje
{
    public interface IUlasim
    {
        int ID { get; set; }
        string Isim { get; set; }
        decimal Ucret { get; set; }
        DateTime seyehatBaslangic { get; set; }
        DateTime seyehatBitis { get; set; }
        bool iptalMi { get; set; }

        List<IUlasim> enUcuzListele(DateTime seyehatBaslangic);
        bool iptalKontrol(int ID);
    }
}
