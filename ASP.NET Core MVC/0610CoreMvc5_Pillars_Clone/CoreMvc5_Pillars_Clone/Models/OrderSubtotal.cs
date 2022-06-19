using System;
using System.Collections.Generic;

#nullable disable

namespace CoreMvc5_Pillars_Clone.Models
{
    public partial class OrderSubtotal
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
