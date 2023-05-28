using Kassa.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kassa.VeriTabanlar
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(50)]
        public string KullaniciAdi { get; set; }
        [StringLength(50)]
        public string Password { get; set; }
        [StringLength(50)]
        public string TelNumara { get; set; }
        public bool Status { get; set; }
        public virtual ICollection<Sold> Solds { get; set; }
    }
    public class MocksUser : Interface
    {
        public User GetUsers { get {
                return new User { Name = "Admin", Password = "Admin", KullaniciAdi = "Admin" };
            }
        }
    }
}
