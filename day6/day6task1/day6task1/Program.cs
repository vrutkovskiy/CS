using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Задание 1.
   
//Цель: Разработать программу, моделирующую танковый бой.  В танковом бою участвуют 5 танков 
//«Т-34» и 5 танков «Pantera». Каждый танк («Т-34» и «Pantera») описываются параметрами: «Боекомплект», 
//«Уровень брони», «Уровень маневренности». Значение данных параметров задаются случайными числами 
//от 0 до 100. Каждый танк участвует в парной битве, т.е. первый танк «Т-34» сражается с первым 
//танком «Pantera» и т.д. Победа присуждается тому танку, который превышает противника по двум 
//и более параметрам из трех (пример: см. программу).  Основное требование:  сражение 
//(проверку на победу в бою) реализовать путем перегрузки оператора «^».

//1.	Создать новый проект с именем «WordOfTanks», в котором будут промоделированы 
//танковые сражения.   В проекте создать папку «Classes», а в ней  создать класс с именем «Tank». 
//В классе должно быть реализовано:
//- поля:
//закрытые поля, предназначенные для представления 
//1. Названия танка. 
//2. Уровня боекомплекта танка. 
//3. Уровня брони.
//4. Уровня маневренности.
//- свойства:
//для доступа к закрытым членам класса.
//-конструктор:
//Конструктор с параметрами, обеспечивающий инициализацию всех полей класса Tank. При этом 
//Боекомплект,  Уровень брони, Уровень маневренности инициализируются случайными числами от 
//0 до 100 %. Название танка передаются в конструктор из функции Main().
//- перегрузка оператора «^»:
//При перегрузке оператора «^»  должна быть реализована проверка на победу в бою одного танка 
//по отношению к другому. Критерий победы – победивший   танк должен превышать проигравший 
//танк не менее чем по двум  из трех параметров (Боекомплект,  Уровень брони, Уровень маневренности). 
//- методы:
//Получение текущих значений параметров танка: Боекомплект,  Уровень брони, Уровень маневренности в виде строки.


//Дополнительный сценарий:
//В результате танковых сражений оставшиеся танки могут сражаться последовательно друг с другом. 
//Алгоритм определения победителя может быть такой же, как и при дуэльном сражении (2 параметра из 3)
//или выбран другой. При этом также можно учесть уменьшение параметров. Если выбирается другой алгоритм, 
//то он должен быть описан в комментариях к методу. 
//Также после первого раунда можно реализовать восстановление танка за счет перегрузки унарного 
//оператора (по выбору). 


namespace day6task1
{
    class Program
    {
        private static Random rnd1 = new Random();

        public static Random Rnd1
        {
            get { return Program.rnd1; }
            set { Program.rnd1 = value; }
        }
        private static Random rnd2 = new Random();

        public static Random Rnd2
        {
            get { return Program.rnd2; }
            set { Program.rnd2 = value; }
        }
                
        static void Main(string[] args)
        {
            const int armysize = 10;
            Tank[] army1 = new Tank[armysize] { new Tank("Tiger"), new Tank("Grosstraktor"), new Tank("Panther"), 
                new Tank("Scorpion"), new Tank("Crusader"), new Tank("Viking"), new Tank("Challenger"),
                new Tank("Black Prince"), new Tank("Matilda"), new Tank ("Leopard")};    //первая армия
            Tank[] army2 = new Tank[armysize] { new Tank("Tiger"), new Tank("Grosstraktor"), new Tank("Panther"), 
                new Tank("Scorpion"), new Tank("Crusader"), new Tank("Viking"), new Tank("Challenger"),
                new Tank("Black Prince"), new Tank("Matilda"), new Tank ("Leopard")};    //вторая армия

            int count = 1;      //количество ходов
            int live = armysize;    //количество живых танков;
            int live1 = 0, live2 = 0;          //количество оставшихся живых танков в одной и другой армии;
            int dead1 = 0, dead2 = 0;            //количество мертвых танков одной и другой армии
            int tank1, tank2;   //выбор танка
            int[] arm1tanks = new int[armysize];   //танк жив = 1/мертв = -1/ не ходил = 0
            int[] arm2tanks = new int[armysize];
            
            do
            {
                
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("{0}{1}", "Ход № ", count);


                do
                {
                    tank1 = rnd1.Next(0, armysize);
                } while (arm1tanks[tank1] != 0);
                do
                {
                    tank2 = rnd1.Next(0, armysize);
                } while (arm2tanks[tank2] != 0);
                Console.Write("{0,-15} {1,-15}", "Танк:", army1[tank1].Name); Console.Write("{0,-15} {1,-15}", "Танк:", army2[tank2].Name);
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("{0,-24} {1,-5}","Количество снарядов: ", army1[tank1].Shells); Console.Write("{0,-22} {1,-5}","Количество снарядов: ", army2[tank2].Shells);
                Console.WriteLine();
                Console.Write("{0,-24} {1,-5}", "Уровень брони: ", army1[tank1].Armor); Console.Write("{0,-22} {1,-5}", "Уровень брони: ", army2[tank2].Armor);
                Console.WriteLine();
                Console.Write("{0,-24} {1,-5}", "Уровень мобильности: ", army1[tank1].Mobility); Console.Write("{0,-22} {1,-5}", "Уровень мобильности: ", army2[tank2].Mobility);
                Console.WriteLine();

                if (army1[tank1] > army2[tank2])
                {
                    arm1tanks[tank1] = 1;
                    arm2tanks[tank2] = -1;
                    ++dead2;
                }
                else
                {
                    arm1tanks[tank1] = -1;
                    arm2tanks[tank2] = 1;
                    ++dead1;
                }
                if (dead1 == armysize || dead2 == armysize)
                    break;

                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Black;
                ++count;
                --live;

                if (live == 0)
                {
                    live1 = 0;
                    live2 = 0;
                    for (int i = 0; i < armysize; ++i)
                    {
                        if (arm1tanks[i] >= 0)
                        {
                            arm1tanks[i] = 0;
                            ++live1;
                        }
                    }
                    Console.WriteLine("Количество живых танков в первой армии : {0}", armysize - dead1);
                    for (int i = 0; i < armysize; ++i)
                    {
                        if (arm2tanks[i] >= 0)
                        {
                            arm2tanks[i] = 0;
                            ++live2;
                        }
                    }
                    Console.WriteLine("Количество живых танков во второй армии : {0}", armysize - dead2);
                    if (live1 > live2)
                        live = live2;
                    else
                        live = live1;
                }
              

            }while (true);


            Console.WriteLine();

            if (armysize - dead1 > 0)
                Console.WriteLine("Победила первая армия");
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("{0, 30}", "");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Победила вторая армия");
            }

            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
    class Tank
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int shells;
        public int Shells
        {
            get { return shells; }
            set { shells = value; }
        }
        private int armor;
        public int Armor
        {
            get { return armor; }
            set { armor = value; }
        }
        private int mobility;
        public int Mobility
        {
            get { return mobility; }
            set { mobility = value; }
        }
        
        public Tank(string uname)
        {
            name = (string)uname.Clone();

            
            shells = Program.Rnd2.Next(0, 100);
            armor = Program.Rnd2.Next(0, 100);
            mobility = Program.Rnd2.Next(0, 100);
        }

        public static bool operator >(Tank a, Tank b)
        {
            if (a.shells + a.armor + a.mobility > b.shells + b.armor + b.mobility)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("{0,-6}{1, -13}{2,10}", "Танк", a.name, " победил! ");
                return true;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("{0, 30}","");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("{0,-6}{1, -13}{2,10}", "Танк", b.name, " победил! ");
                return false;
            }  
        }
        public static bool operator <(Tank a, Tank b)
        {
            if (a.shells + a.armor + a.mobility < b.shells + b.armor + b.mobility)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Танк " + b.name + " победил! ");
                return true;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Танк " + a.name + " победил! ");
                return false;
            }
        }
    }
}
