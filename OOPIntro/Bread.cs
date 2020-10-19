using System;
using System.Collections.Generic;
using System.Text;

namespace OOPIntro
{
    class Bread : Product
    {
        private string _tasteOfBread;

        public string TasteOfBread
        {
            get { return _tasteOfBread; }
            set { _tasteOfBread = value; }
        }
    }
}
