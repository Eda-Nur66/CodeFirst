using System;


using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Mekanlar :IDisposable
    {
        SehirDbContext ctx = new SehirDbContext();
       
        public void Dispose()
        {
            ((IDisposable)ctx).Dispose();
        }

        public bool Ekle(Mekanlar   m)
        {
            ctx.Mekanlar.Add(m);
            return ctx.SaveChanges() > 0;
        }

    }
}
