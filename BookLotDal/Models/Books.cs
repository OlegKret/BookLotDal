using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookLotDal.Models
{
    [Table("Books")]
    public partial class Books
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }

        [Required]
        public int AuthorId { get; set; }
        [ForeignKey("AuthorId")]
        public virtual Authors Authors { get; set; }

        [Required]
        public int PublisherId { get; set; }
        [ForeignKey("PublisherId")]
        public virtual Publishers Publishers { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(50)]
        
        public string ISBN { get; set; }

        [StringLength(50)]
        public string Genre { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [StringLength(50)]
        public string PublicationYear { get; set; }

        [Required]
        [Index("IDX_Books_Price", IsUnique = false)]
        public int Price { get; set; }

        [StringLength(50)]
        public string Condition { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }

        [NotMapped]
        public string FullName => Title + " " + ISBN;

        public virtual ICollection<OrderItem> Orders { get; set; } = new HashSet<OrderItem>();
    }
}
