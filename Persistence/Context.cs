using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntrenmanTakip.Persistence
{
    public static class Context
    {
        public static DbAntrenmanTakip2Entities _context = new DbAntrenmanTakip2Entities();
        public static Kullanicilar kullanici;
        public static Sporcular sporcu;
    }
}
