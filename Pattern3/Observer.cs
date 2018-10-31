using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern3
{
    interface Observer
    {
        void subscribe(string msg, string userName);
    }
}
