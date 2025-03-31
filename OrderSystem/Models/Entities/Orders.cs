using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderSystem.Models.Entities
{
    public class Orders
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("Сумма", TypeName = "decimal(10, 2)")]
        public required Decimal Amount { get; set; }

        [Column("Дата_и_время")]
        public required DateTime OrderDate { get; set; }

        [Column("Статус")]
        public required OrderStatus Status { get; set; }

        [ForeignKey("clients")]
        [Column("ClientID")]
        public int ClientId { get; set; }
        public Clients Client {  get; set; }
    }
}

public enum OrderStatus
{
    NotProcessed,
    Cancelled,
    Completed
}
