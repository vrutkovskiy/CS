using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankSystemLib
{
    public class Bank
    {

        private Client[] clients;
        private int size;

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public Bank(int usize)
        {
            this.size = usize;
            clients = new Client[size];
        }
        private static int clientcount; //количество клиентов
        private static int trylog;  //три попытки ввести лог
        private static int trypas;  //три попытки ввести пас
        private static Random rnd1 = new Random();  //для получения счета

        public static Random Rnd1
        {
            get { return rnd1; }
            set { rnd1 = value; }
        }
        static Bank()
        {
            clientcount = 0;
            trylog = 0;
            trypas = 0;
        }

        public int Checklog(string ulog)
        {
            int rez = 100;      //100 - неверный(несуществующий) логин, 0 корректный логин, 200 - три попытки истекли
            if (clientcount > 0)
            {
                for (int i = 0; i < clientcount; ++i)
                {
                    if (ulog == clients[i].Acc.Login)
                        rez = 0;
                }
            }
            if (rez != 0)
            {
                ++trylog;
                if (trylog == 3)
                {
                    trylog = 0;
                    rez = 200;
                }
            }
            return rez;
        }
        public int Checkpas(string upas)
        {

            int rez = 100;      //100 - неверный(несуществующий) пароль, 0 корректный пароль, 200 - три попытки истекли
            if (clientcount > 0)
            {
                for (int i = 0; i < clientcount; ++i)
                {
                    if (upas == clients[i].Acc.Password)
                        rez = 0;
                }
            }
            if (rez != 0)
            {
                ++trypas;
                if (trypas == 3)
                {
                    trypas = 0;
                    rez = 200;
                }
            }
            return rez;
        }
        public int Create(string uname, string usur, string upasport, string ulog, string upas)
        {

            int[] moda = new int[upas.Length];
            int n = 0;
            if (clientcount > 0 && clientcount <= size)
            {
                for (int i = 0; i < clientcount; ++i)
                    if (clients[i].Name == uname)
                    {
                        if (clients[i].Surname == usur)
                            return 300;     //такой клиент существует
                    }
                for (int i = 0; i < clientcount; ++i)
                    if (clients[i].Acc.Login == ulog)
                        return 500;     //такой логин существует
            }
            else
                if (clientcount == size)
                    return 400;     //достигнуто максимальное количество клиентов.
            if (upas.Length <= 5)
                return 600;     //пароль слишком короткий

            for (int i = 0; i < upas.Length; ++i)
            {
                for (int j = 0; j < upas.Length; ++j)
                {
                    if (upas[i] == upas[j])
                    {
                        ++n;
                        moda[i] = n;
                    }
                }
                n = 0;
            }
            int max = moda[0];
            for (int i = 0; i < upas.Length; ++i)
                if (moda[i] > max)
                    max = moda[i];

            if (max >= 3)
                return 700; // в пароле много повторяющихся букв

            clients[clientcount] = new Client(uname, usur, upasport, ulog, upas);
            ++clientcount;
            return 0;
        }

        public Int64 openmainacc(string ulog, string upas)
        {
            Int64 tempacc;
            int flag = 0;
            do
            {
                tempacc = (Int64)3013 * 1000000000 + rnd1.Next(10000, 99999) * 10000 + rnd1.Next(1000, 9999);
                for (int i = 0; i < clientcount; ++i)
                    if (clients[i].Acc.Mainaccount != 0 && clients[i].Acc.Mainaccount == tempacc)   //проверка счета на уникальность
                        flag = 1;

            } while (flag != 0);

            for (int i = 0; i < clientcount; ++i)
                if (ulog == clients[i].Acc.Login)
                    if (upas == clients[i].Acc.Password)
                    {
                        clients[i].Acc.Mainaccount = tempacc;
                    }
            return tempacc;
        }
        public Int64 openreservacc(string ulog, string upas)
        {
            Int64 tempacc;
            int flag = 0;
            do
            {
                tempacc = (Int64)3013 * 1000000000 + rnd1.Next(10000, 99999) * 10000 + rnd1.Next(1000, 9999);
                for (int i = 0; i < clientcount; ++i)
                    if (clients[i].Acc.Reservaccount != 0 && clients[i].Acc.Reservaccount == tempacc)   //проверка счета на уникальность
                        flag = 1;
            } while (flag != 0);

            for (int i = 0; i < clientcount; ++i)
                if (ulog == clients[i].Acc.Login)
                    if (upas == clients[i].Acc.Password)
                    {
                        clients[i].Acc.Reservaccount = tempacc;
                    }
            return tempacc;
        }
        public int toacc(string ulog, string upas)
        {
            for (int i = 0; i < clientcount; ++i)
                if (ulog == clients[i].Acc.Login)
                    if (upas == clients[i].Acc.Password)
                    {
                        if (clients[i].Acc.Mainaccount != 0 && clients[i].Acc.Reservaccount == 0)
                            return 100;     // открыт только основной счет
                        if (clients[i].Acc.Mainaccount == 0 && clients[i].Acc.Reservaccount != 0)
                            return 200;     // открыт только резервный счет
                        if (clients[i].Acc.Mainaccount == 0 && clients[i].Acc.Reservaccount == 0)
                            return 500;     //закрыты оба счета
                    }

            return 0;       //открыты оба счета
        }

        public void addtoacc(string ulog, string upas, ref Int64 acc, ref double balance, double sum, int mainres)
        { 
             for (int i = 0; i < clientcount; ++i)
                if (ulog == clients[i].Acc.Login)
                    if (upas == clients[i].Acc.Password)
                    {
                        acc = (mainres == 1 ? clients[i].Acc.Mainaccount : clients[i].Acc.Reservaccount);
                        if(mainres == 1) 
                            clients[i].Acc.Mainaccbalance += sum;
                        else
                            clients[i].Acc.Reservaccbalance += sum;


                        balance = (mainres == 1 ? clients[i].Acc.Mainaccbalance : clients[i].Acc.Reservaccbalance);
                    }
        }

        public int withdrawacc(string ulog, string upas, ref Int64 acc, ref double balance, double sum, int mainres)
        {
            int percent = 3;
             for (int i = 0; i < clientcount; ++i)
                if (ulog == clients[i].Acc.Login)
                    if (upas == clients[i].Acc.Password)
                    {
                        acc = (mainres == 1 ? clients[i].Acc.Mainaccount : clients[i].Acc.Reservaccount);
                        if (mainres == 1)
                        {
                            if (clients[i].Acc.Mainaccbalance < (sum + (sum * percent / 100)))
                                return 200; // недостаточно средств
                            else
                                clients[i].Acc.Mainaccbalance -= (sum + (sum * percent / 100));
                        }
                        else
                        {
                            if (clients[i].Acc.Reservaccbalance < (sum + (sum * percent / 100)))
                                return 200; // недостаточно средств
                            else
                                clients[i].Acc.Reservaccbalance -= (sum + (sum * percent / 100));
                        }
                        balance = (mainres == 1 ? clients[i].Acc.Mainaccbalance : clients[i].Acc.Reservaccbalance);
                    }
             return 0;
        }

    }
}
