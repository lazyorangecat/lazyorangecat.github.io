using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_03_03
{
    internal class ChargeLevel
    {
        public int HalfHourLowerBound半小時下限 { get; set; }

        public int ChargeBate半小時費率 { get; set; }

        public ChargeLevel() { }

        public ChargeLevel(int halfHourLowerBound, int chargeBate)
        {
            HalfHourLowerBound半小時下限 = halfHourLowerBound;
            ChargeBate半小時費率 = chargeBate;
        }
    }
}
