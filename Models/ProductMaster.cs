using System;
using System.Collections.Generic;

namespace ProductManagement.Models
{
    public partial class ProductMaster
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
