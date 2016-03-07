using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSystemLib;


namespace BankSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank obj = new Bank(5);
            int choise;     //выбор в первом меню
            int trylog;        //проверка логина на 3 попытки/верность
            int trypas;        //проверка пароля на 3 попытки/верность
            int crea;       //проверка клиента на дублирование/ макс количество клиентов
            int accstatus;  // состояние счетов 500 - не открыты оба, 100 - открыт основной, 200 - открыт резервный, 0 - открыты оба
            string log;     //логин для доступа к счету
            string pas;     //пароль для доступа к счету
            int choiseacc;  //выбор счета (меню2)
           

            do
            {
                choise = obj.Greeting();
                if (choise == 1)
                {
                    do
                    {
                        trylog = obj.Checklog(log = obj.showlog());
                        if (trylog == 0)
                        {
                            do
                            {
                                trypas = obj.Checkpas(pas = obj.showpas());
                                if (trypas == 0)
                                {
                                    do
                                    {
                                        accstatus = obj.toacc(log, pas);
                                        if (accstatus == 0)
                                        {
                                            choiseacc = obj.showchoseacc();
                                            if (choiseacc == 1)
                                                Progmainaccoper(obj, log, pas);
                                            if (choiseacc == 2)
                                                Progreservaccoper(obj, log, pas);
                                            if (choiseacc <= 0 || choiseacc > 2)
                                                break;
                                        }
                                        if (accstatus == 500)
                                        {
                                            choiseacc = obj.showmenuacc();
                                            if (choiseacc == 1)
                                            {
                                                Progopenmain(obj, log, pas);
                                            }
                                            if (choiseacc == 2)
                                            {
                                                Progopenreserv(obj, log, pas);
                                            }
                                            if (choiseacc <= 0 || choiseacc > 2)
                                                break;
                                        }
                                        if (accstatus == 100)
                                        {
                                            choiseacc = obj.showaccORopenacc(1);
                                            if (choiseacc == 1)
                                                Progmainaccoper(obj, log, pas);
                                            if (choiseacc == 2)
                                            {
                                                Progopenreserv(obj, log, pas);
                                            }
                                            if (choiseacc <= 0 || choiseacc > 2)
                                                break;
                                        }
                                        if (accstatus == 200)
                                        {
                                            choiseacc = obj.showaccORopenacc(2);
                                            if (choiseacc == 1)
                                                Progreservaccoper(obj, log, pas);
                                            if (choiseacc == 2)
                                            {
                                                Progopenmain(obj, log, pas);
                                            }
                                            if (choiseacc <= 0 || choiseacc > 2)
                                                break;
                                        }
                                    } while (true);
                                    break;
                                }
                                if (trypas == 100)
                                    obj.tryagain(2);
                                if (trypas == 200)
                                {
                                    obj.tryexpir();
                                    break;
                                }
                            } while (true);
                            break;
                        }

                        if (trylog == 100)
                            obj.tryagain(1);
                        if (trylog == 200)
                        {
                            obj.tryexpir();
                            break;
                        }

                    } while (true);
                }

                if (choise == 2)
                {
                    crea = obj.Create(obj.showname(), obj.showsurname(), obj.showpasport(), obj.showlog(), obj.showpas());
                    if (crea == 300)
                        obj.showexist(1);
                    if (crea == 400)
                        obj.showmaxclients();
                    if (crea == 500)
                        obj.showexist(2);
                    if (crea == 600)
                        obj.showbadpas(1);
                    if (crea == 700)
                        obj.showbadpas(2);
                    if (crea == 0)
                        obj.shownext();
                }

                if (choise <= 0 || choise > 2)
                    break;
            } while (true);
        }

        public static void Progmainaccoper(Bank obj, string ulog, string upas)
        {
            int choise; //меню3
            Int64 acc = 0;
            double balance = 0;
            int withdrfail;
            do
            {
                choise = obj.showaccoper(1);
                if (choise == 1)
                {
                    obj.addtoacc(ulog, upas, ref acc, ref balance, 0, 1);
                    obj.showacc(1, acc);
                    obj.showbalance(balance);
                }
                if (choise == 2)
                {
                    obj.addtoacc(ulog, upas, ref acc, ref balance, obj.showoper(1), 1);
                    obj.addtoacc(ulog, upas, ref acc, ref balance, 0, 1);
                    obj.showacc(1, acc);
                    obj.showbalance(balance);
                }
                if (choise == 3)
                {
                    withdrfail = obj.withdrawacc(ulog, upas, ref acc, ref balance, obj.showoper(2), 1);
                    if (withdrfail == 200)
                        obj.showwithdrfail();
                    obj.addtoacc(ulog, upas, ref acc, ref balance, 0, 1);
                    obj.showacc(1, acc);
                    obj.showbalance(balance);
                }
                if (choise <= 0 || choise > 3)
                    break;

            } while (true);
        }
        public static void Progreservaccoper(Bank obj, string ulog, string upas)
        {
            int choise; //меню3
            Int64 acc = 0;
            double balance = 0;
            int withdrfail;
            do
            {
                choise = obj.showaccoper(2);
                if (choise == 1)
                {
                    obj.addtoacc(ulog, upas, ref acc, ref balance, 0, 2);
                    obj.showacc(2, acc);
                    obj.showbalance(balance);
                }
                if (choise == 2)
                {
                    obj.addtoacc(ulog, upas, ref acc, ref balance, obj.showoper(1), 2);
                    obj.addtoacc(ulog, upas, ref acc, ref balance, 0, 2);
                    obj.showacc(2, acc);
                    obj.showbalance(balance);
                }
                if (choise == 3)
                {
                    withdrfail = obj.withdrawacc(ulog, upas, ref acc, ref balance, obj.showoper(2), 2);
                    if (withdrfail == 200)
                        obj.showwithdrfail();
                    obj.addtoacc(ulog, upas, ref acc, ref balance, 0, 2);
                    obj.showacc(1, acc);
                    obj.showbalance(balance);
                }
                if (choise <= 0 || choise > 3)
                    break;
            } while (true);
        }
        public static void Progopenmain(Bank obj, string ulog, string upas)
        {
            Int64 acc;   
            acc = obj.openmainacc(ulog, upas);
            obj.showacc(1, acc);
        }
        public static void Progopenreserv(Bank obj, string ulog, string upas)
        {
            Int64 acc;
            acc = obj.openreservacc(ulog, upas);
            obj.showacc(2, acc);
        }

    }


}
