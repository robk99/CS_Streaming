using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Session.Domain.Session
{
    public enum SessionState
    {
        PLAY = 0,
        PAUSE = 1,
        RESUME = 2,
        SEEK = 3,
        STOP = 4,
        CLOSED = 5
    }
}
