using System;
using System.Collections.Generic;
using System.Security.Principal;
using Microsoft.EntityFrameworkCore;


namespace Tasarim.Models
{
    public class BiletContext1:DbContext
    {
        public BiletContext1()
        {
            //Yapıcı metot:Bu yapıcı metot, testler veya varsayılan ayarlarla DbContext oluşturmak için kullanılabilir.
        }
        public BiletContext1(DbContextOptions<BiletContext1> options)
            :base(options)
        {
        }
        public virtual DbSet<BiletBilgilerii> BiletBilgilers { get; set; }
        public virtual DbSet<FirmaBilgileri> FirmaBilgileris { get; set; }
        public virtual DbSet<GuzergahBilgileri> GuzergahBilgileris { get; set; }
        public virtual DbSet<KoltukBilgileri> KoltukBilgileris { get; set; }
        public virtual DbSet<OtobusBilgileri> OtobusBilgileris { get; set; }
        public virtual DbSet<SeferBilgileri>SeferBilgileris { get; set; }
        public virtual DbSet<SehirBilgileri> SehirBilgileris { get; set; }
        public virtual DbSet<UyeBilgileri> UyeBilgileris { get; set; }
        public virtual DbSet<YolcuBilgileri> YolcuBilgileris { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
            => optionsBuilder.UseSqlServer("Data Source=.\\Data\\Bilet.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BiletBilgilerii>(entity =>
            {
                entity.ToTable("BiletBilgilerii");

              
            });
        }

    }
}
