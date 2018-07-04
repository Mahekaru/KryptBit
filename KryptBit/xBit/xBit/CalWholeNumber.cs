using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KryptBit
{
    class CalWholeNumber
    {
        public int RoundData(int DataNum)
        {
            int DataLength,DataValue;
            
            DataLength = DataNum.ToString().Length;
            DataValue = Convert.ToInt32(DataNum.ToString().Substring(DataLength - 1, 1));
            if (DataValue > 0)
            {
                DataValue = Convert.ToInt32(DataNum.ToString().Substring(0, DataLength - 1) + "1");
            }
            else
            {
                DataValue = DataNum;
            }
            return DataValue;
        }
    }
}
