
using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class Product : IEntity
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string QuantityPerUnit { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]
        public short UnitsInStock { get; set; }
    }
}
