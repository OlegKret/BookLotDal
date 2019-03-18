using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookLotDal.Models
{
   
    public partial class Authors
    {
        [Key,Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuthorId { get; set; }

        [StringLength(50)]
        
        public string AuthorFirstName { get; set; }

        [StringLength(50)]
        
        public string AuthorLastName { get; set; }
        
        [Timestamp]
        public byte[] Timestamp { get; set; }

        [NotMapped]
        public string FullName => AuthorFirstName + " " + AuthorLastName;

       
    }
}
