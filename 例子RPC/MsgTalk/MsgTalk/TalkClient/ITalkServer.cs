﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TalkClient
{
    interface TalkService
    {
        bool IsLogIn(string name);
        void SendALL(string msg);
        int value(int a, int b);
    }
}
