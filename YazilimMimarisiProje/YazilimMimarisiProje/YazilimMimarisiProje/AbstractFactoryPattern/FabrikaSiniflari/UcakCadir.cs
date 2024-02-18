
namespace YazilimMimarisiProje
{
    public class UcakCadir : AbstractFactrory
    {
        public override IKonaklama CreateKonaklama()
        {
            return new Cadir();
        }

        public override IUlasim CreateUlasim()
        {
            return new Ucak();
        }
    }
}
