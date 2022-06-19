using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildSchoolBizApp.ViewModels
{
    internal class InvetoryQueryViewModel
    {
        public string PartNo { get; set; }
        public string PartName { get; set; }
        public int TotalInvetoryQuantity { get; set; }
    }
}
