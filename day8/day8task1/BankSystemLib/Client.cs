using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemLib
{
    public class Client
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string surname;
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
       
        private string passport;
        public string Passport
        {
            get { return passport; }
            set { passport = value; }
        }

        Account acc;

        public Account Acc
        {
            get { return acc; }
            set { acc = value; }
        }
        

        public Client()
            : this("Пустой объект", "Пустой объект", "Пустой объект", null, null)
        { }
        public Client(string uname, string usur, string upasport, string ulog, string upas)
        {
            this.name = uname;
            this.surname = usur;
            this.passport = upasport;
            this.acc = new Account(ulog, upas);
        }
      


    }
}
