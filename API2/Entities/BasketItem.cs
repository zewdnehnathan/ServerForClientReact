using System.ComponentModel.DataAnnotations.Schema;

namespace API2.Entities
{
    [Table("BasketItems")]
    public class BasketItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        //navigation Properties
        public int ProductId { get; set; }
        public Product Product { get; set; }

        //additional navigation properties
        public int BasksetId { get; set; }
        public Basket Basket{ get; set; }

    }
}