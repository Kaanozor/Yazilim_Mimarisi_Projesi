
namespace YazilimMimarisiProje
{
    internal class OtobusCadir : AbstractFactrory
    {
        public override IKonaklama CreateKonaklama()
        {
            return new Cadir();
        }

        public override IUlasim CreateUlasim()
        {
            return new Otobus();
        }


    }
}
