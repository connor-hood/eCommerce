using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public virtual User User { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string AgeRating { get; set; }
        public string Genre { get; set; }
        public int Price { get; set; }
        public string ImageURL { get; set; }

        //public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }
    }
}
