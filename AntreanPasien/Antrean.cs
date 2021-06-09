namespace AntreanPasien
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Antrean")]
    public partial class Antrean
    {
        [Key]
        public int NoAntrean { get; set; }

        [StringLength(50)]
        public string Nama { get; set; }

        private readonly DataModel dbo = Akses.Tabel();
        bool status;

        public bool Tambah(string nama)
        {
            status = false;

            if (!dbo.Antreans.Any(x => x.Nama == nama))
            {
                dbo.Antreans.Add(new Antrean()
                {
                    Nama = nama,
                });
                dbo.SaveChanges();
                status = true;
            }

            return status;
        }
        public bool Ubah(int kondisi, string nama)
        {
            status = false;

            if (!dbo.Antreans.Any(x => x.Nama == nama))
            {
                var antrean = dbo.Antreans.Where(x => x.NoAntrean == kondisi);
                foreach (var x in antrean)
                {
                    x.Nama = nama;
                }
                status = true;
            }
            dbo.SaveChanges();
            return status;
        }

        public bool Hapus(string nama = "")
        {
            if (nama != "")
            {
                dbo.Antreans.RemoveRange(dbo.Antreans
                .Where(x => x.Nama == nama));

                status = true;
            }
            else { status = false; }
            dbo.SaveChanges();
            return status;
        }
        public bool Kosong()
        {
            status = false;
            if(!dbo.Antreans.Any())
            {
                status = true;
            }
            return status;
        }

        public void Reset()
        {
            var data = (from n in dbo.Antreans select n);
            dbo.Antreans.RemoveRange(data);
            dbo.SaveChanges();
        }
    }
}
