using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookLotDal.Models
{
    [Table("SalesBook")]
    public partial class SalesBook
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SalesBookId { get; set; }

        [Timestamp]
        public byte[] TimeStamp { get; set; }

        [Required, StringLength(50)]
        [Index("IDX_SalesBook_TitleAction", IsUnique = true)]
        public string TitleAction { get; set; }

        [Required]
        public int BookId { get; set; }
        [ForeignKey("BookId")]
        public virtual Books Books { get; set; }

        public virtual ICollection<OrderItem> Orders { get; set; } = new HashSet<OrderItem>();
    }
}
