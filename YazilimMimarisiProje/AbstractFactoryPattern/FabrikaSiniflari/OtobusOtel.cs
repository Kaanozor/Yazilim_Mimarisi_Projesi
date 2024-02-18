using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisiProje
{
    public class OtobusOtel : ISoyutFabrika
    {
        public IKonaklama TatilKonaklama()
        {
            return new Cadir();
        }



        public IUlasim TatilUlasim()
        {
            return new Otobus();
        }
    }
}
