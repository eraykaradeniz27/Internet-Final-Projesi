using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace projeödev.Models
{
    public class database:DbContext
    {
        public DbSet<Ogrenci> Ogrencis { get; set; }
        public DbSet<OkulYonetim> OkulYonetims { get; set; }
        public DbSet<Ders> Derss { get; set; }
        public DbSet<OgrenciDers> OgrenciDerss { get; set; }
    }
}