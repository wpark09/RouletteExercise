using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette1
{
    class Outcome
    {
        public int result=0;
        public string display="";
        public int color=0;

        public Outcome(int result)
        {
            this.result = result;
        }

        public Outcome(int result, string display, int color)
        {
            this.result = result;
            this.display = display;
            this.color = color;
        }
    }
}
