using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fruitivy.Models
{
    public class Produk
    {
        [Key]
        public int ProdukId { get; set; }
        public string Nama { get; set; }
        public byte[] Picture { get; set; }
        public int Stok { get; set; }
        public int Harga { get; set; }
        public string Email { get; set; }
     
        [Display(Name = "Penjual")]
        public virtual int Id { get; set; }

        [ForeignKey("Id")]
        public virtual Penjual Penjuals { get; set; }
    }
}
