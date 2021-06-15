using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class ShoppingCart
    {
        public int ShoppingCartId { get; set; }

        //Check these later
        [ForeignKey("Product")]
        public string ProductId { get; set; }
        public Product Product { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }

        //wouldn't the above 2 lines take care of the many-to-many relationship
        public virtual ICollection<Product> Products { get; set; }


        //If there are two entity type ‘Customer’ and ‘Account’ then each ‘Customer’ can have more than one ‘Account’
        //but each ‘Account’ is held by only one ‘Customer’. In this example, we can say that each Customer
        //is associated with many Account. So, it is a one-to-many relationship. But, if we see it the other way i.e many
        //Account is associated with one Customer then we can say that it is a many-to-one relationship.




        //public partial class ShoppingCart
        //{
        //    public int UserId { get; set; }
        //    public int ProductId { get; set; }
        //    public int? Quantity { get; set; }
        //    public virtual Product Product { get; set; }
        //    public virtual User User { get; set; }
        //}

    }

}
