using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SailingAid
{
    internal class GpsData
    {
        private double speed;
        private double heading;

        public GpsData()
        { 
            speed = 0.0;
            heading= 0.0;
        }

        public double GetSpeed()
        {
            return speed;
        }

        public void SetSpeed(double s) 
        {
            speed = s;
        }

        public double GetHeading()
        {
            return heading;
        }

        public void SetHeading(double h) 
        {
            heading = h; 
        }
    }
}
