using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Utils
{
    public class MovementPoint
    {
        public decimal Lat { get; set; }
        public decimal Lon { get; set; }
        public decimal? Azimuth { get; set; }
        public DateTime Date { get; set; }
    }
}
