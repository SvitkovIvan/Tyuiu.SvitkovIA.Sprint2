using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SvitkovIA.Sprint2.Task2.V7.Lib
{
    public class DataService : ISprint2Task2V7
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((y >= 3) && (y <= 5) && (x >= 3) && (x <= 4))
            {
                res = true;
            }
            else
            if ((y >= 9) && (y <= 12) && (x >= 3) && (x <= 4))
            {
                res = true;
            }
            else
            if ((y >= 3) && (y <= 12) && (x >= 5) && (x <= 7))
            {
                res = true;
            }
            else
            if ((y == 13) && (x >= 6) && (x <= 7))
            {
                res = true;
            }
            else
            if ((y >= 4) && (y <= 12) && (x == 8))
            {
                res = true;
            }
            else
            if ((y == 13) && (x == 8))
            {
                res = true;
            }
            else
            if ((y >= 4) && (y <= 5) && (x >= 9) && (x <= 13))
            {
                res = true;
            }
            else
            if ((y >= 10) && (y <= 12) && (x >= 9) && (x <= 11))
            {
                res = true;
            }
            else
            if ((y == 3) && (x == 11))
            {
                res = true;
            }
            else
            if ((y == 6) && (x >= 12) && (x <= 13))
            {
                res = true;
            }
            else
            if ((y == 10) && (x == 12))
            {
                res = true;
            }
            else
            {
                res = false;
            }


            return res;

         
            
                    

        }
    }
}
            
     

       
