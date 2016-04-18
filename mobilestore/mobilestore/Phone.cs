using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace mobilestore
{
    [Serializable]
    public class Phone
    {
        private string phname;
        public string Phname
        {
            get { return phname; }
            set { phname = value; }
        }
        private string os;
        public string Os
        {
            get { return os; }
            set { os = value; }
        }
        private string procesr;

        public string Procesr
        {
            get { return procesr; }
            set { procesr = value; }
        }
        private string picpath;

        public string Picpath
        {
            get { return picpath; }
            set { picpath = value; }
        }
        private decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        BindingList<Option> opts;

        public BindingList<Option> Opts
        {
            get { return opts; }
            set { opts = value; }
        }
        public Phone()
        {
            opts = new BindingList<Option>();
            picpath = @"pics\nophoto.jpg";
        }

        public override string ToString()
        {
            return String.Format(phname + ". " + os + " - " + procesr + " Цена = " + price);
        }

    }
}
