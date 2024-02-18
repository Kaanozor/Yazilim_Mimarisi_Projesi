using System;
using System.Collections.Generic;


namespace YazilimMimarisiProje
{
    public static class DataSource
    {
        public static List<IKonaklama> otelListe;
        public static List<IUlasim> ucakListe;
        public static List<IKonaklama> cadirListe;
        public static List<IUlasim> otobusListe;
        static DataSource()
        {
            otelListe = new List<IKonaklama>();
            ucakListe = new List<IUlasim>();
            cadirListe = new List<IKonaklama>();
            otobusListe = new List<IUlasim>();
            otelListe = OtelEkle();
            ucakListe = UcakEkle();
            cadirListe = CadirEkle();
            otobusListe = OtobusEkle();
        }

        private static List<IUlasim> OtobusEkle()
        {
            for (int i = 0; i < 100; i++)
            {
                otobusListe.Add(new Otobus
                {
                    ID = i + 100,
                    Isim = FakeData.NameData.GetCompanyName(),
                    Ucret = decimal.Parse(FakeData.TextData.GetNumeric(3)),
                    seyehatBaslangic = FakeData.DateTimeData.GetDatetime(DateTime.Parse("22.05.2022"), DateTime.Parse("10.06.2022"))

                });
            }
            return otobusListe;

        }
        private static List<IKonaklama> OtelEkle()
        {
            for (int i = 0; i < 100; i++)
            {
                otelListe.Add(new Otel
                {
                    ID = i + 100,
                    Isim = FakeData.PlaceData.GetCounty(),
                    Ucret = decimal.Parse(FakeData.TextData.GetNumeric(3)),
                    seyehatBaslangic = FakeData.DateTimeData.GetDatetime(DateTime.Parse("22.05.2022"), DateTime.Parse("10.06.2022"))

                });
            }
            return otelListe;

        }

        private static List<IKonaklama> CadirEkle()
        {
            for (int i = 0; i < 100; i++)
            {
                cadirListe.Add(new Cadir
                {
                    ID = i + 100,
                    Isim = FakeData.PlaceData.GetStreetName(),
                    Ucret = decimal.Parse(FakeData.TextData.GetNumeric(3)),
                    seyehatBaslangic = FakeData.DateTimeData.GetDatetime(DateTime.Parse("22.05.2022"), DateTime.Parse("10.06.2022"))

                });
            }
            return cadirListe;

        }
        private static List<IUlasim> UcakEkle()
        {
            for (int i = 0; i < 100; i++)
            {
                ucakListe.Add(new Ucak
                {
                    ID = i + 100,
                    Isim = FakeData.NameData.GetCompanyName(),
                    Ucret = decimal.Parse(FakeData.TextData.GetNumeric(3)),
                    seyehatBaslangic = FakeData.DateTimeData.GetDatetime(DateTime.Parse("22.05.2022"), DateTime.Parse("10.06.2022"))

                });
            }
            return ucakListe;

        }
    }
}
