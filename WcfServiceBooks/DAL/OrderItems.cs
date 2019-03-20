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
    [Table("OrderItems")]
    public class OrderItems
    {
        [DataMember]
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }

        [DataMember]
        [Required]
        public int BookId { get; set; }

        [DataMember]
        [ForeignKey("BookId")]
        public virtual Books Books { get; set; }

        [DataMember]
        [Index("IDX_OrderItem_Quantity", IsUnique = false)]
        public int Quantity { get; set; }

        [DataMember]
        [Index("IDX_OrderItem_Price", IsUnique = false)]
        [Column(TypeName = "Money")]
        public int Price { get; set; }

        [DataMember]
        [Timestamp]
        public byte[] Timestamp { get; set; }

        [DataMember]
        [NotMapped]
        public string FullName => Quantity + " " + Price;

      
    }
}