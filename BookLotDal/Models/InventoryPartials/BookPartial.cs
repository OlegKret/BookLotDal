using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BookLotDal.Models
{
    public partial class Books
    {
        public override string ToString()
        {
            return $"{this.Title ?? "**No Name**"} is a{this.Genre} " +
                $"with ID{this.ISBN}{this.Price}";
        }
        [NotMapped]
        public string TitAuth => $"{Title} + ({Genre})";
    }
    
}
