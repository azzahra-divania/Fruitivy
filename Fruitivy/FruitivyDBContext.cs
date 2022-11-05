using Fruitivy.Models;
using Microsoft.EntityFrameworkCore;

namespace Fruitivy
{
    public class FruitivyDBContext : DbContext
    {
        public FruitivyDBContext(DbContextOptions<FruitivyDBContext> options) : base(options)
        {

        }
        //create table di bawah sini (mendaftarkan table dari kelas yg sudah dibuat):
        //dbcontext
        public DbSet<Pembeli> pembeli { get; set; }
        public DbSet<Penjual> penjual { get; set; }
        public DbSet<Produk> produk { get; set; }
        public DbSet<Transaksi> transaksi { get; set; }
    }
}
