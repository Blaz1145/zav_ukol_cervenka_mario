using System.ComponentModel.DataAnnotations;

namespace UTBAirlines.Domain.Entities
{
    public class Letenka
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Destinace { get; set; }

        public double Cena { get; set; }
    }
}