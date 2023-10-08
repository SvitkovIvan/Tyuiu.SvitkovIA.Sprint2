﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SvitkovIA.Sprint2.Task4.V7.Lib
{
    public class DataService : ISprint2Task4V7
    {
        public double Calculate(double x, double y)
        {

            double z = (x - 10 > y + 2) ? Math.Pow((1 + Math.Sqrt(x + 3) / Math.Pow(x, 2)), y) : (Math.Pow(x, 3) + 2 * x + (6 + 4 / Math.Pow(y, 2)));
            return Math.Round(z, 3);
        }
    }
}
