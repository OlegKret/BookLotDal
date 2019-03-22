using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Data.Entity;

namespace WcfServiceBooks.DAL
{
    [DataContract]
    [Table("Books")]
    public class Books
    {
        [DataMember]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }

        [DataMember]
        public int AuthorId { get; set; }

        [DataMember]
        public int PublisherId { get; set; }

        [DataMember]
        [StringLength(50)]
        public string Title { get; set; }

        [DataMember]
        [StringLength(50)]
        public string ISBN { get; set; }

        [DataMember]
        [StringLength(50)]
        public string Genre { get; set; }

        [DataMember]
        [StringLength(50)]
        public string Type { get; set; }

        [DataMember]
        [StringLength(50)]
        public string PublicationYear { get; set; }

        [DataMember]
        [Required]
        [Index("IDX_Books_Price", IsUnique = false)]
        public int Price { get; set; }

        [DataMember]
        [StringLength(50)]
        public string Condition { get; set; }

        [DataMember]
        [NotMapped]
        public string FullName => Title + " " + ISBN;

        public virtual ICollection<OrderItems> Orders { get; set; } = new HashSet<OrderItems>();
    }
}