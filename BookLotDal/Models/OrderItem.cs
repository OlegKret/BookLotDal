using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLotDal.Models
{
    [Table("OrderItems")]
    public partial class OrderItem
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        
        [Required]
        public int BookId { get; set; }
        
        [ForeignKey("BookId")]
        public virtual Books Books { get; set; }

        [Index("IDX_OrderItem_Quantity", IsUnique =false)]
        public int Quantity { get; set; }

        [Index("IDX_OrderItem_Price", IsUnique = false)]
        [Column(TypeName = "Money")]
        public int Price { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }

        [NotMapped]
        public string FullName => Quantity + " " + Price;

        public virtual ICollection<Orders> GetOrders { get; set; } = new HashSet<Orders>();
    }
}
