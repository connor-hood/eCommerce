using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class Review
    {
        //should this class also be many to many
        public int ReviewId { get; set; }
        public int Rating { get; set; }
        public string Text { get; set; }

        [ForeignKey("Product")]

        //why do we make this is a string?
        public string ProductId { get; set; }
        public Product Product { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
