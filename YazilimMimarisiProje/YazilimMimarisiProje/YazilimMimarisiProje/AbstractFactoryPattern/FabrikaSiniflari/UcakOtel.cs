
namespace YazilimMimarisiProje
{
    public class UcakOtel : AbstractFactrory
    {
        public override IKonaklama CreateKonaklama()
        {
            return new Otel();
        }

        public override IUlasim CreateUlasim()
        {
            return new Ucak();
        }
    }
}
