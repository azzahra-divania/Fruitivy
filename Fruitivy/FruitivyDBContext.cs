using Microsoft.EntityFrameworkCore;

namespace Fruitivy
{
    public class FruitivyDBContext : DbContext
    {
        public FruitivyDBContext(DbContextOptions<FruitivyDBContext> options) : base(options)
        {

        }
        //create table di bawah sini
    }
}
