using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AntreanPasien
{
    public partial class DataModel : DbContext
    {
        public DataModel()
            : base("name=DataModel")
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Antrean> Antreans { get; set; }
        public virtual DbSet<Pasien> Pasiens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
