using System.Collections.Generic;

namespace GeekShopping.Web.Models
{
    public class CartViewModel
    {
        public CartHeaderViewModel CartHeader { get; set; }
        public IEnumerable<CartHeaderViewModel> CartDetails { get; set; }
    }
}
