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
   
    public class User
    {
        [DataMember]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DataMember]
        [StringLength(50)]
        [Required]
        public string Login { get; set; }

        [DataMember]
        [StringLength(50)]
        [Required]
        public string Password { get; set; }

        [DataMember]
        [StringLength(50)]
        [Required]
        public string Email { get; set; }

        [DataMember]
        [StringLength(50)]
        [Required]
        public string PhoneNumber { get; set; }

        [DataMember]
        [StringLength(50)]
        [Required]
        public string PhotoName { get; set; }


        [DataMember]
        [NotMapped]
        public byte[] Photo { get; set; }

    }
}