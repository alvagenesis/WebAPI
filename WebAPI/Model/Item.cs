using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Model
{
    public class Item
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        public required string Code { get; set; }
        
        [Column(TypeName = "varchar(100)")]
        public required string Description { get; set; }
        
        [Column(TypeName = "bit")]
        public required string Status { get; set; }
        
        [Column(TypeName = "bit")]
        public required string IsActive { get; set; }

    }
}
