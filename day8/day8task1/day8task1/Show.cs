using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSystemLib;

//Задание: Написать приложение, имитирующее работу БАНКА при работе с юридическим лицом. 

//Постановка задачи:
//1.	Юридическое лицо желает открыть счет в банке. При этом заполнить личные данные 
//(фамилия, имя, номер паспорта) и параметры авторизации (имя пользователя и пароль) для 
//входа в систему «Клиент-банк». 
//2.	После проверки уникальности имени пользователя, надежности пароля банк открывает юр. 
//лицу счет. При этом банк сообщает юр. лицу номер расчетного счета и процент, который взымает 
//банк при снятии юр. лицом денег. 
//3.	После успешного открытия счета пользователь входит на свой счет в системе «Клиент-банк», 
//используя имя пользователя и пароль,  для выполнения банковских операций (просмотр текущего баланса,   
//пополнение счёта,  снятие денег со счёта). При этом если у клиента имеется несколько счетов 
//(основной и резервный), то выводится меню для выбора номера расчетного счета. 
//4.	Если юридическое лицо уже имеет счет в банке, он может активировать дополнительный (резервный) 
//счет, используя уже имеющиеся личные данные, обратившись в банк! 



//Особенности работы юр лица в системе «Клиент-банк»
//1.	Система «Клиент-банк» предлагает ввести имя пользователя и пароль. При этом даётся всего 
//3 попытки на правильный ввод пароля. Если попытки исчерпаны, система «Клиент-банк» выдаёт 
//соответствующее сообщение и закрывается.
//2.	При успешном вводе пароля выводится меню. Пользователь может выбрать одно из нескольких действий:
//         - вывод баланса на экран
//         - пополнение счёта
//         - снять деньги со счёта
//         - выход
//3. Если пользователь выбирает вывод баланса на экран, приложение отображает состояние текущего 
//счёта, после чего предлагает либо вернуться в меню, либо совершить выход.
//4. Если пользователь выбирает пополнение счёта, программа запрашивает сумму для пополнения и выполняет 
//операцию, сопровождая её выводом соответствующего комментария. Затем следует предложение вернуться в 
//меню или выполнить выход.
//5. Если пользователь выбирает снять деньги со  счёта, программа запрашивает сумму. Если сумма превышает 
//сумму счёта пользователя, программа выдаёт сообщение и переводит пользователя в меню. Иначе отображается 
//сообщение о  том, что сумма снята со счёта, и уменьшается сумма на счёте на указанную величину 
//+ снимаются проценты банком.

//Технические особенности реализации:
//1.	Создать библиотеку классов (.dll)
//2.	В библиотеке классов реализовать классы Bank, Client, Account в различных пространствах имен 
//(общее пространство имен «BankSystem»).


namespace BankSystem
{
    public static class Show
    {

        public static int Greeting(this Bank bank)
        {
            Console.WriteLine();
            Console.WriteLine("{0, 40}", "Вас приветствует СуперБанк!");
            Console.WriteLine("{0, 30}", "*** MENU ***");
            Console.WriteLine("{0, 10}{1, -30}", " ", "1) Войти в личный кабинет.");
            Console.WriteLine("{0, 10}{1, -30}", " ", "2) Создать аккаунт.");
            Console.WriteLine("{0, 10}{1, -30}", " ", "3) Выйти.");
            string buf = Console.ReadLine();
            return Int32.Parse(buf);
        }
        public static string showlog(this Bank bank)
        {
            Console.Write("{0, 10}{1, -30}", " ", "Введите логин : ");
            string buf = Console.ReadLine();
            Console.WriteLine();
            return buf;

        }
        public static string showpas(this Bank bank)
        {
            Console.Write("{0, 10}{1, -30}", " ", "Введите пароль : ");
            string buf = Console.ReadLine();
            Console.WriteLine();
            return buf;
        }

        public static void tryagain(this Bank bank, int logpas)
        {
            Console.WriteLine("{0, 10}{1}{2}{3}", " ", "Неверный ", 
                logpas == 1 ? "логин. " : "пароль. ", "Попробуйте снова:");
        }

        public static void tryexpir(this Bank bank)
        {
            Console.WriteLine("{0, 10}{1, -30}", " ", "Три попытки ввода истекли.");
        }

        public static string showname(this Bank bank)
        {
            Console.Write("{0, 10}{1, -30}", " ", "Введите имя : ");
            string buf = Console.ReadLine();
            Console.WriteLine();
            return buf;
        }
        public static string showsurname(this Bank bank)
        {
            Console.Write("{0, 10}{1, -30}", " ", "Введите фамилию : ");
            string buf = Console.ReadLine();
            Console.WriteLine();
            return buf;
        }
        public static string showpasport(this Bank bank)
        {
            Console.Write("{0, 10}{1, -30}", " ", "Введите номер паспорта : ");
            string buf = Console.ReadLine();
            Console.WriteLine();
            return buf;
        }
        public static int showmenuacc(this Bank bank)
        {
            Console.WriteLine("{0, 10}{1, -30}", " ", "1) Если хотите открыть основной счет нажмите 1 : ");
            Console.WriteLine("{0, 10}{1, -30}", " ", "2) Если хотите открыть резервный счет нажмите 2 : ");
            Console.WriteLine("{0, 10}{1, -30}", " ", "3) Если не хотите открывать счета в данный момент нажмите 3 : ");
            string buf = Console.ReadLine();
            Console.WriteLine();
            return Int32.Parse(buf);
        }
        public static void showexist(this Bank bank, int clielog)
        {
            Console.WriteLine("{0, 10}{1}{2}{3}", " ", "Такой ", clielog == 1? "клиент " : "логин ", "уже существует.");
        }

        public static void showmaxclients(this Bank bank)
        {
            Console.WriteLine("{0, 10}{1, -30}", " ", 
                "В данный момент банк не набирает больше клиентов. Приносим свои извинения.");
        }
        public static int showchoseacc(this Bank bank)
        {
            Console.WriteLine("{0, 10}{1, -30}", " ", "1) Операции по основному счету.");
            Console.WriteLine("{0, 10}{1, -30}", " ", "2) Операции по резервному счету.");
            Console.WriteLine("{0, 10}{1, -30}", " ", "3) Выйти из личного кабинета.");
            string buf = Console.ReadLine();
            Console.WriteLine();
            return Int32.Parse(buf);
        }
        public static int showaccORopenacc(this Bank bank, int mainres)
        {
            Console.WriteLine("{0, 10}{1}{2}{3}", " ", "1) Операции по ", 
                mainres == 1 ? "основному " : "резервному ", "счету.");
            Console.WriteLine("{0, 10}{1}{2}{3}", " ", "2) Открыть ", 
                mainres == 1 ? "резерный " : "основной ", "счет.");
            Console.WriteLine("{0, 10}{1}", " ",        "3) Выйти из личного кабинета.");
            string buf = Console.ReadLine();
            Console.WriteLine();
            return Int32.Parse(buf);
        }

        public static void shownext(this Bank bank)
        {
            Console.WriteLine("{0, 10}{1, -30}", " ", "Для открытия счетов и операций с ними зайдите в личный кабинет.");
        }

        public static void showacc(this Bank bank, int mainres, Int64 acc)
        {
            Console.Write("{0, 10}{1}{2}{3}", " ", "Ваш ", mainres == 1 ? "основной " : "резервный ", "счет : ");
            Console.WriteLine("{0}", acc);
            Console.WriteLine("{0, 10}{1}", " ", "Процент за снятие денег со счета составляет 3%.");
        }

        public static int showaccoper(this Bank bank, int mainres)
        {
            Console.WriteLine("{0, 10}{1}{2}{3}", " ", "Операции по ", 
                mainres == 1 ? "основному " : "резервному ", "счету: ");
            Console.WriteLine("{0, 10}{1}", " ", "1) Проверить баланс. ");
            Console.WriteLine("{0, 10}{1}", " ", "2) Пополнить счет. ");
            Console.WriteLine("{0, 10}{1}", " ", "3) Снять со счета. ");
            Console.WriteLine("{0, 10}{1}", " ", "4) Выйти в предыдущее меню. ");
            string buf = Console.ReadLine();
            Console.WriteLine();
            return Int32.Parse(buf);
        }
        public static void showbadpas(this Bank bank, int variant)
        {
            Console.WriteLine("{0, 10}{1}", " ", variant == 1 ? "Ваш пароль слишком короткий. " : 
                "В Вашем пароле слишком много повторяющихся символов. ");
            Console.WriteLine("{0, 10}{1}", " ", "Попробуйте ввести другой пароль. ");
        }

        public static void showbalance(this Bank bank, double balance)
        {
            Console.WriteLine("{0, 10}{1}{2}{3}", " ", "На счету : ", balance, " рублей.");
        }
        public static double showoper(this Bank bank, int variant)
        {
            Console.Write("{0, 10}{1}{2}", " ", "Введите сумму которую хотите ", variant == 1 ? "зачислить: ": "снять : ");
            string buf = Console.ReadLine();
            Console.WriteLine();
            return Double.Parse(buf);
        }
        public static void showwithdrfail(this Bank bank)
        {
            Console.WriteLine("{0, 10}{1}", " ", "Извините на счете не достаточно средств для снития такой суммы. ");
        }




    }
}
