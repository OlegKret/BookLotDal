using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BookLotDal.Models
{
    public partial class Orders
    {
        public override string ToString()
        {
            return $"{this.TitAuth ?? "**No Name**"} is a{this.OrderDate} " +
                $"with ID{this.OrderId}{this.Total}";
        }
        [NotMapped]
        public string TitAuth => $"{Total} + ({Subtotal})";
    }

}