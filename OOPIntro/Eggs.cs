using System;
using System.Collections.Generic;
using System.Text;

namespace OOPIntro
{
    class Eggs : Product
    {
        private int _eggStatus;

        public int EggStatus
        {
            get { return _eggStatus; }
            set { _eggStatus = value; }
        }
    }
}
