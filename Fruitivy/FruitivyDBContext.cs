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
        public DbSet<Pembeli> pembeli { get; set; }
    }
}
