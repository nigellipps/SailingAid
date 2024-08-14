using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SailingAid
{
    public interface IData : IGyroscopeData, IGpsData { }

public interface IGpsData
    {
    }

    public interface IGyroscopeData
    {
    }

    internal class DataProcessing: IData
    {
        public DataProcessing() { }
    }
}
