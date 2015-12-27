﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZYSocket.RPC
{
    public static class MakeID
    {
        public static DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1, 0, 0, 0, 0));
        public static Random R = new Random();
        public static long GetID()
        {          
            System.DateTime nowTime = System.DateTime.Now;
            long tick= nowTime.Ticks - startTime.Ticks;
            tick = tick * 10000000;
            tick += R.Next(1, 9999999);

            return tick;
        }
    }
}
