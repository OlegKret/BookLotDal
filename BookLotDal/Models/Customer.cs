using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLotDal.Models
{
    [Table("Customer")]
    public partial class Customer
    {
        [Key,Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustId { get; set; }

        [StringLength(50)]
        
        public string FirstName { get; set; }

        [StringLength(50)]
      
        public string LastName { get; set; }

        [StringLength(50)]
        public string StreetNumber { get; set; }

        [StringLength(50)]
       
        public string StreetName { get; set; }

        [StringLength(50)]
        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }

        [StringLength(50)]
        public string Province { get; set; }

      
        [StringLength(50)]
      
        public string PhoneNumber { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }

        [NotMapped]
        public string FullName => FirstName + " " + LastName;

        public virtual ICollection<Orders> Orders { get; set; } = new HashSet<Orders>();
    }
}
