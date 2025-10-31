using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Receipt
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string TotalAmount { get; set; }

        public IEnumerable<Receipt_Product> Receipt_Products { get; set; } = new List<Receipt_Product>();



    }
}
