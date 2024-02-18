using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisiProje
{
    public class UcakOtel : ISoyutFabrika
    {
        public IKonaklama TatilKonaklama()
        {
            return new Otel();
        }



        public IUlasim TatilUlasim()
        {
            return new Ucak();
        }
    }
}
