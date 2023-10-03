using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SvitkovIA.Sprint2.Task1.V9.Lib
{
    public class DataService : ISprint2Task1V9
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a == c) | (b >= d);
            res[1] = (a != b) & (b <= c);
            res[2] = (a == b) || (b > c);
            res[3] = (b <= d) && (a > c);
            res[4] = !(a > d);
            res[5] = (b <= d) ^ (c > a);

            return res;
        }
    }
}
