using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;
using System.Text.RegularExpressions;

namespace mobilestore
{
    public class Iniwork
    {
        private string phonepath;

        public string Phonepath
        {
            get { return phonepath; }
            set { phonepath = value; }
        }

        private string optpath;

        public string Optpath
        {
            get { return optpath; }
            set { optpath = value; }
        }
        public void create(ref BindingList<Option> options)
        {
            phonepath = @"phones.ini";
            optpath = @"opts.ini";

            string dirpath = @"pics";

            string menu = "n";
            string optsmenu = "n";
            BindingList<Option> phnopts = new BindingList<Option>();
            bool addcoll = true;

            using (FileStream filo = new FileStream(Phonepath, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter strWr = new StreamWriter(filo))
                {
                    string str;
                    do
                    {
                        Console.Write("Введите название телефона : ");
                        str = Console.ReadLine();
                        strWr.WriteLine(str);

                        Console.Write("Введите операционную систему телефона : ");
                        str = Console.ReadLine();
                        strWr.WriteLine(str);

                        Console.Write("Введите процессор телефона : ");
                        str = Console.ReadLine();
                        strWr.WriteLine(str);

                        Console.Write("Введите цену телефона : ");
                        str = Console.ReadLine();
                        strWr.WriteLine(str);

                        if (!Directory.Exists(dirpath))
                            Directory.CreateDirectory(dirpath);
                        Console.Write("Введите название картинки телефона (типа: phone.jpg) : ");
                        str = dirpath + "\\" + Console.ReadLine();
                        strWr.WriteLine(str);

                        phnopts.Clear();
                        do
                        {
                            Console.Write("Введите название опции : ");
                            str = Console.ReadLine();

                            for (int i = 0; i < phnopts.Count; ++i)
                                if (phnopts[i].Optname.Equals(str))
                                {
                                    addcoll = false;
                                    break;
                                }
                            if (addcoll)
                            {
                                phnopts.Add(new Option() { Optname = str });
                            }
                            else
                                Console.WriteLine("Такая опция уже существует.");
                            addcoll = true;

                            Console.Write("Закончить ввод опций (y/n) : ");
                            optsmenu = Console.ReadLine();

                        } while (optsmenu.CompareTo("y") != 0);
                        str = "";
                        addcoll = true;
                        for (int i = 0; i < phnopts.Count; ++i)
                        {
                            for (int j = 0; j < options.Count; ++j)
                                if (options[j].Optname.Equals(phnopts[i].Optname))
                                {
                                    addcoll = false;
                                    break;
                                }
                            if (addcoll)
                            {
                                options.Add(new Option() { Optname = phnopts[i].Optname });
                            }

                            addcoll = true;
                            str += phnopts[i].Optname + " ";
                        }
                        strWr.WriteLine(str);

                        Console.Write("Закончить ввод телефонов (y/n) : ");
                        menu = Console.ReadLine();

                    } while (menu.CompareTo("y") != 0);
                }
            }

            menu = "n";
            using (FileStream filo = new FileStream(Optpath, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter strWr = new StreamWriter(filo))
                {
                    string str;
                    do
                    {
                        Console.Write("Введите название опции : ");
                        str = Console.ReadLine();
                        addcoll = true;

                        for (int j = 0; j < options.Count; ++j)
                            if (options[j].Optname.Equals(str))
                            {
                                addcoll = false;
                                break;
                            }
                        if (addcoll)
                        {
                            options.Add(new Option() { Optname = str });
                        }
                        else
                            Console.WriteLine("Такая опция уже существует.");

                        //если будет нужно
                        //Console.Write("Введите описание опции : ");
                        //str = Console.ReadLine();
                        //strWr.WriteLine(str);

                        Console.Write("Закончить ввод опций (y/n) : ");
                        menu = Console.ReadLine();

                    } while (menu.CompareTo("y") != 0);
                    for (int i = 0; i < options.Count; ++i)
                        strWr.WriteLine(options[i].Optname);
                }
            }
        }

        public void readini(out string readphoneini, out string readoptini)
        {
            readphoneini = File.ReadAllText(@"phones.ini");
            readoptini = File.ReadAllText(@"opts.ini");
        }

        public void parseini(string readphoneini, string readoptini,
            ref BindingList<Phone> phones, ref BindingList<Option> options)
        {
            string[] masstr;
            string[] masopt;
            bool addcoll = true;
            string pattern = "\\n+";
            string pattern1 = "\\s+";
            Regex reg = new Regex(pattern);

            masstr = reg.Split(readphoneini);
            reg = new Regex(pattern1);
            for (int i = 0; i < masstr.Length - 1; i += 6)
            {
                phones.Add(new Phone()
                {
                    Phname = masstr[i],
                    Os = masstr[i + 1],
                    Procesr = masstr[i + 2],
                    Price = Decimal.Parse(masstr[i + 3]),
                    Picpath = masstr[i+4]
                });

                masopt = reg.Split(masstr[i + 5]);
                for (int j = 0; j < masopt.Length - 1; ++j)
                    phones[phones.Count - 1].Opts.Add(new Option() { Optname = masopt[j] });
            }

            masstr = reg.Split(readoptini);
            for (int i = 0; i < masstr.Length - 1; ++i /*i+= 2*/) // если будет описание
            {
                addcoll = true;

                for (int j = 0; j < options.Count; ++j)
                    if (options[j].Optname.Equals(masstr[i]))
                    {
                        addcoll = false;
                        break;
                    }
                if (addcoll)
                {
                    options.Add(new Option() { Optname = masstr[i] });
                }
            }
        }

    }
}

