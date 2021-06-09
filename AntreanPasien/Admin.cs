namespace AntreanPasien
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Admin")]
    public partial class Admin
    {
        private readonly DataModel dbo = Akses.Tabel();
        bool status;
        public int Id { get; set; }

        [StringLength(20)]
        public string Username { get; set; }

        [StringLength(20)]
        public string Password { get; set; }
        public List<Admin> GetListSemuaDataBerdasarkan()
        {
            return dbo.Admins.Select(x => x).ToList();
        }
        public bool CekBerdasarkan(string username = "", string password = "")
        {
            bool tempStatus = false;

            if (username != "" && password != "")
                tempStatus = dbo.Admins.Any(x => x.Username == username && x.Password == password);
            else if (username != "")
                tempStatus = dbo.Admins.Any(x => x.Username == username);
            else if (password != "")
                tempStatus = dbo.Admins.Any(x => x.Password == password);

            return tempStatus;
        }
        public bool Tambah(string username, string password)
        {
            status = false;

            if (!dbo.Admins.Any(x => x.Username == username))
            {
                dbo.Admins.Add(new Admin()
                {
                    Username = username,
                    Password = password
                });
                dbo.SaveChanges();
                status = true;
            }

            return status;
        }
        public bool Ubah(int kondisi, string username = "", string password = "")
        {
            var admin = dbo.Admins.Where(x => x.Id == kondisi);
            foreach (var x in admin)
            {
                x.Username = username;
                x.Password = password;
            }
            status = true;

            dbo.SaveChanges();
            return status;
        }
        public bool Hapus(string username = "", string password = "")
        {
            if (username != "" && password != "")
            {
                dbo.Admins.RemoveRange(dbo.Admins
                .Where(x => x.Username == username && x.Password == password));

                status = true;
            }
            else { status = false; }
            dbo.SaveChanges();
            return status;
        }
    }
}
