using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Result
    {
        private int id;
        private int signClass;
        private string lattitude;
        private string longitude;
        private DateTime date;
        private int roadId;
        private double roadKm;

        public int getId()
        {
            return this.id;
        }
        public int getSignClass()
        {
            return this.signClass;
        }
        public string getLattitude()
        {
            return this.lattitude;
        }
        public string getLongitude()
        {
            return this.longitude;
        }
        public DateTime getDate()
        {
            return this.date;
        }
        public int getRoadId()
        {
            return this.roadId;
        }
        public double getRoadKm()
        {
            return this.roadKm;
        }
    }
}
