

namespace YazilimMimarisiProje
{
    public class OtobusOtel : AbstractFactrory
    {
        public override IKonaklama CreateKonaklama()
        {
            return new Otel();
        }

        public override IUlasim CreateUlasim()
        {
            return new Otobus();
        }

    }
}
