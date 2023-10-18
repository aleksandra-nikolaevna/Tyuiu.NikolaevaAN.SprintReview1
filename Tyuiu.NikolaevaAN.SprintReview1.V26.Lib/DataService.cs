﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NikolaevaAN.SprintReview1.V26.Lib
{
    public class DataService : ISprint1Task7V26
    {
        public double Calculate(double x, double y)
        {
            double z = ((Math.Sin(Math.Pow(x, 2)) + y) / (y + 1)) - ((x * y - 12) / (34 + Math.Pow(x, 2)));
            return Math.Round(z, 3);
        }
    }
}