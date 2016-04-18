using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobilestore
{
    [Serializable]
    public class Option
    {
        private string optname;

        public string Optname
        {
            get { return optname; }
            set { optname = value; }
        }
        private string descr;

        public string Descr
        {
            get { return descr; }
            set { descr = value; }
        }
        public override string ToString()
        {
            return String.Format(optname);
        }
        public Option()
        { }
    }
}
