using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookLotDal.Models
{
    [Table("Orders")]
    public partial class Orders
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        
        [Required]
        public int CustId { get; set; }

        [ForeignKey("CustId")]
        public virtual Customer Customer { get; set; }

        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        [Index("IDX_Orders_Subtotal", IsUnique = false)]
        [Column(TypeName = "Money")]
        public int Subtotal{ get; set; }

        [StringLength(50)]
        public string Shipping { get; set; }

        [Index("IDX_OrderItem_Total", IsUnique = false)]
        [Column(TypeName = "Money")]
        public int Total { get; set; }
       

        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
