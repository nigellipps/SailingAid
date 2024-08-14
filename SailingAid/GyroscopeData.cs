using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SailingAid
{
    internal class GyroscopeData : IGyroscopeData
    {
        private double angularVelocity;
        private double orientation;

        public GyroscopeData()
        {
            angularVelocity = 0.0;
            orientation = 0.0;
        }

        public double GetAngularVelocy()
        {
            return angularVelocity;
        }

        public void SetAngularVelocity(double v)
        {
            angularVelocity = v;
        }

        public double GetOrientation()
        {
            return orientation;
        }

        public void SetOrientation(double o)
        {
            orientation = o;
        }
    }
}
