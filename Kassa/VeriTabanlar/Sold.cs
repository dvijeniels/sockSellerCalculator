using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kassa.VeriTabanlar
{
    public class Sold
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public List<int> ProductId { get; set; }
        public int UserId { get; set; }
        public DateTime Tarih { get; set; }
        public decimal WorkerPriceTotal { get; set; }
        public decimal CompanyPriceTotal { get; set; }
        public virtual Product Products { get; set; }
        public virtual User Users { get; set; }
    }
}
