using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Receipt_Product
    {
        public Guid Id { get; set; }

        public IEnumerable<Receipt> Receipt { get; set; } = new List<Receipt>();
        public IEnumerable<Product> Products { get; set; } = new List<Product>();

        public string Quantity { get; set; } = string.Empty;
        public int PriceDuringSale { get; set; }
    }
}
