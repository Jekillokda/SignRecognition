using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    [Serializable]
    public class Result
    {
        public int id;
        public int signClass;
        public string lattitude;
        public string longitude;
        public DateTime date;
        public int roadId;
        public double roadKm;

        public Result()
        { }

        public Result(int id, int sClass, string lat, string lon, DateTime date, int roadId, double roadKm)
        {
            this.id = id;
            this.signClass = sClass;
            this.lattitude = lat;
            this.longitude = lon;
            this.date = date;
            this.roadId = roadId;
            this.roadKm = roadKm;
        }

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
