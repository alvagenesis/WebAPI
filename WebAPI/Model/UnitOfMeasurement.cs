using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Model
{
    public class UnitOfMeasurement
    {
        public int Id { get; set; }

        public int ItemId { get; set; }

        public Item Item { get; set; } = null!;

        [Column(TypeName = "varchar(100)")]
        public required string Name { get; set; }

        [Column(TypeName = "bit")]
        public required string Status { get; set; }

        [Column(TypeName = "bit")]
        public required string IsActive { get; set; }

        [Column(TypeName = "decimal(10,4)")]
        public int IsSmallestUnit { get; set; }


    }
}
