using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Fruitivy.Models
{
    public class Transaksi
    {
        [Key]
        public int TransaksiId { get; set; }
        public double TotalHarga { get; set; }
        public DateTime Tanggal { get; set; }
        public int Stok { get; set; }

        [Display(Name = "Pembeli")]
        public virtual int Id { get; set; }

        [ForeignKey("Id")]
        public virtual Pembeli Pembelis { get; set; }

        [Display(Name = "Produk")]
        public virtual int ProdukId { get; set; }

        [ForeignKey("ProdukId")]
        public virtual Produk Produks { get; set; }
    }
}
