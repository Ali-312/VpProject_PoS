using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VpProject_PoS
{
    internal class InvoiceItem
    {
        public int Id { get; set; } // Primary Key
        public string? ProductID { get; set; }
        public string? ProductName { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public decimal SubTotal { get; set; }
        public int InvoiceNumber { get; set; }
    }
}
