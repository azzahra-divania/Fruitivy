using System.ComponentModel.DataAnnotations;

namespace Fruitivy.Models
{
    public class Penjual
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Alamat { get; set; }
        public string NoHp { get; set; }
        public string Email { get; set; }
    }
}
