using System;
using System.Collections.Generic;

#nullable disable

namespace CoreMvc5_Pillars_Clone.Models
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
