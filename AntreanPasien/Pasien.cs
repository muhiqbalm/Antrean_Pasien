namespace AntreanPasien
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Pasien")]
    public partial class Pasien
    {
        private readonly DataModel dbo = Akses.Tabel();
        bool status;
        public int Id { get; set; }

        public string Nama { get; set; }

        public string Alamat { get; set; }

        [StringLength(20)]
        public string NoHP { get; set; }

        public List<Pasien> GetListSemuaDataBerdasarkan()
        {
            return dbo.Pasiens.Select(x => x).ToList();
        }
        public bool Tambah(string nama, string alamat, string nohp)
        {
            status = false;

            if (!dbo.Pasiens.Any(x => x.Nama == nama && x.Alamat == alamat && x.NoHP == nohp ))
            {
                dbo.Pasiens.Add(new Pasien()
                {
                    Nama = nama,
                    Alamat = alamat,
                    NoHP = nohp
                });
                dbo.SaveChanges();
                status = true;
            }

            return status;
        }
        public bool Ubah(int kondisi, string nama, string alamat, string nohp)
        {
            status = false;

            if (!dbo.Pasiens.Any(x => x.Nama == nama && x.Alamat == alamat && x.NoHP == nohp))
            {
                var pasien = dbo.Pasiens.Where(x => x.Id == kondisi);
                foreach (var x in pasien)
                {
                    x.Nama = nama;
                    x.Alamat = alamat;
                    x.NoHP = nohp;
                }
                status = true;
            }
            dbo.SaveChanges();
            return status;
        }
        public bool Hapus(string nama = "", string alamat = "", string nohp = "")
        {
            if (nama != "" && alamat != "" && nohp != "")
            {
                dbo.Pasiens.RemoveRange(dbo.Pasiens
                .Where(x => x.Nama == nama && x.Alamat == alamat && x.NoHP == nohp));

                status = true;
            }
            else { status = false; }
            dbo.SaveChanges();
            return status;
        }
    }
}
