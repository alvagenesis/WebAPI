using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Model
{
    public class UnitOfMeasurement
    {
        public int Id { get; set; }

        public int ItemId { get; set; }        

        [Column(TypeName = "varchar(100)")]
        public string Name { get; set; }
        
        public bool Status { get; set; }
       
        public bool IsActive { get; set; }
        
        [Column(TypeName = "decimal(10, 4)")]        
        public decimal IsSmallestUnit { get; set; }
    }
}
