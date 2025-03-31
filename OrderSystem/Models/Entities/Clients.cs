using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderSystem.Models.Entities
{
    public class Clients
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("Имя")]
        [MaxLength(50)]
        public required string FirstName { get; set; }

        [Column("Фамилия")]
        [MaxLength(50)]
        public required string LastName { get; set; }

        [Column("Дата_рождения")]
        public required DateTime BirthDate { get; set; }
        public List<Orders> Orders { get; set; } = new();
    }
}
