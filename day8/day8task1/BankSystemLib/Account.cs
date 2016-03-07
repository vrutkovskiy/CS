using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemLib
{
    public class Account
    {
        private string login;
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private Int64 mainaccount;

        public Int64 Mainaccount
        {
            get { return mainaccount; }
            set { mainaccount = value; }
        }
        private Int64 reservaccount;

        public Int64 Reservaccount
        {
            get { return reservaccount; }
            set { reservaccount = value; }
        }

        public Account(string ulog, string upas)
        {
            this.login = ulog;
            this.password = upas;
        }
        private double mainaccbalance;
        public double Mainaccbalance
        {
            get { return mainaccbalance; }
            set { mainaccbalance = value; }
        }
        private double reservaccbalance;
        public double Reservaccbalance
        {
            get { return reservaccbalance; }
            set { reservaccbalance = value; }
        }

    }
}
