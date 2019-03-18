using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLotDal.Models
{
    [Table("Publishers")]
    public partial class Publishers
    {
        [Key,Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PublisherId { get; set; }

        [StringLength(50)]
        public string PublisherName { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }

    
    }
}
