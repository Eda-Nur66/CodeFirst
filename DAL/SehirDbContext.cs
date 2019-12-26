using BLL;
using MODELS;
using System;

using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SehirDbContext:DbContext
    {
        public SehirDbContext() : base("cstr")
        {

        }

        public DbSet<Mekanlar> Mekanlar { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
    }
}
