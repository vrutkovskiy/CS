using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace mobilestore
{
    [Serializable]
    public partial class Form1 : Form
    {
        BindingList<Phone> phones;
        BindingList<Option> options;
        Iniwork myini;
        bool check;
        public Form1()
        {
            phones = new BindingList<Phone>();
            options = new BindingList<Option>();
            myini = new Iniwork();
            check = true;
            InitializeComponent();
        }

        private void Addopt_Click(object sender, EventArgs e)
        {
            int selindex = 0;
            if (PhonesBox.SelectedItem != null)
                selindex = PhonesBox.SelectedIndex;

            bool addcoll = true;

            if (!String.IsNullOrEmpty(optname.Text))
            {
                addcoll = true;
                for (int j = 0; j < options.Count; ++j)
                    if (options[j].Optname.Equals(optname.Text))
                    {
                        addcoll = false;
                        break;
                    }
                if (addcoll)
                {
                    options.Add(new Option() { Optname = optname.Text });

                    if (PhonesBox.Items.Count != 0)
                    {
                        PhonesBox.SetSelected(selindex, false);
                        PhonesBox.SetSelected(selindex, true);
                    }
                    else
                        PhonesBox.SelectedItem = false;
                }
                else
                    MessageBox.Show("Такая опция уже существует.", "Внимание!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Введите название опции.", "Внимание!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            PhoneoptoinsBox.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            //myini.create(ref options);     //для первого запуска !!!!ВКЛЮЧИТЬ КОНСОЛЬ!!!!

            if (File.Exists(@"serialphone.txt") && File.Exists(@"serialopts.txt"))
                Serial.deserial(ref phones, ref options);
            else
            {
                string readphoneini;
                string readoptini;
                myini.readini(out readphoneini, out readoptini);
                myini.parseini(readphoneini, readoptini, ref phones, ref options);
            }
            PhonesBox.DataSource = phones;
            Optionbox.DataSource = options;         //datasource не виден интелисенсом !!!!!!!
            phones.Add(new Phone() { Phname = "Nokla", Os = "Win" });
            Option sel;
            if (PhonesBox.SelectedItem != null)
            {
                Phone ph = (Phone)PhonesBox.SelectedItem;
                for (int j = 0; j < Optionbox.Items.Count; ++j)
                {

                    sel = (Option)Optionbox.Items[j];

                    for (int i = 0; i < ph.Opts.Count; ++i)
                        if (ph.Opts[i].Optname.Equals(sel.Optname))
                        {
                            check = true;
                            break;
                        }
                        else
                        {
                            check = false;

                        }


                    if (check && ph.Opts.Count != 0)
                        Optionbox.SetItemChecked(Optionbox.Items.IndexOf(sel), true);
                    else
                        Optionbox.SetItemChecked(Optionbox.Items.IndexOf(sel), false);
                    check = true;
                }
            }
        }

        private void delopt_Click(object sender, EventArgs e)
        {
            BindingList<Option> chekopt = new BindingList<Option>();
            for (int j = 0; j < Optionbox.Items.Count; j++)
            {
                if (Optionbox.GetItemChecked(Optionbox.Items.IndexOf(Optionbox.Items[j])) == true)
                {
                    chekopt.Add((Option)Optionbox.Items[j]);
                }
            }
            for (int i = 0; i < chekopt.Count; ++i)
            {
                for (int j = 0; j < Optionbox.Items.Count; j++)
                    if (chekopt[i].Optname.Equals(((Option)Optionbox.Items[j]).Optname))
                    {
                        options.Remove((Option)Optionbox.Items[j]);
                        break;
                    }

            }


        }

        private void PhonesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PhonesBox.SelectedItem != null)
            {
                Phone ph = (Phone)PhonesBox.SelectedItem;
                Modeltb.Text = ph.Phname;
                Ostb.Text = ph.Os;
                Procesrtb.Text = ph.Procesr;
                Pricetb.Text = ph.Price.ToString();
                pictureBox1.ImageLocation = ph.Picpath;
                PhoneoptoinsBox.Items.Clear();
                for (int i = 0; i < ph.Opts.Count; ++i)
                    PhoneoptoinsBox.Items.Add(ph.Opts[i].Optname);
                Editmodeltb.Text = ph.Phname;
                Editostb.Text = ph.Os;
                Editprocsrtb.Text = ph.Procesr;
                Editpicpathtb.Text = ph.Picpath;
                Editpricetb.Text = ph.Price.ToString();
                Option sel;

                for (int j = 0; j < Optionbox.Items.Count; ++j)
                {

                    sel = (Option)Optionbox.Items[j];
                    for (int i = 0; i < ph.Opts.Count; ++i)
                        if (ph.Opts[i].Optname.Equals(sel.Optname))
                        {
                            check = true;
                            break;
                        }
                        else
                        {
                            check = false;

                        }


                    if (check && ph.Opts.Count != 0)
                        Optionbox.SetItemChecked(Optionbox.Items.IndexOf(sel), true);
                    else
                        Optionbox.SetItemChecked(Optionbox.Items.IndexOf(sel), false);
                    check = true;
                }

            }
            else
            {
                Modeltb.Text = "";
                Ostb.Text = "";
                Procesrtb.Text = "";
                Pricetb.Text = "";
                pictureBox1.ImageLocation = "";
                PhoneoptoinsBox.Items.Clear();
                Editmodeltb.Text = "";
                Editostb.Text = "";
                Editprocsrtb.Text = "";
                Editpicpathtb.Text = "";
                Editpricetb.Text = "";
            }
        }


        private void savechangebtn_Click(object sender, EventArgs e)
        {
            if (PhonesBox.SelectedItem != null)
            {
                Phone ph = (Phone)PhonesBox.SelectedItem;
                Phone ph1 = ph;
                if (!String.IsNullOrEmpty(Editmodeltb.Text))
                    ph.Phname = Editmodeltb.Text;
                if (!String.IsNullOrEmpty(Editostb.Text))
                    ph.Os = Editostb.Text;
                if (!String.IsNullOrEmpty(Editprocsrtb.Text))
                    ph.Procesr = Editprocsrtb.Text;
                if (!String.IsNullOrEmpty(Editpicpathtb.Text))
                    ph.Picpath = Editpicpathtb.Text;
                if (!String.IsNullOrEmpty(Editpricetb.Text))
                    ph.Price = Decimal.Parse(Editpricetb.Text);

                Option sel;
                if (PhonesBox.SelectedItem != null)
                {
                    for (int j = 0; j < Optionbox.Items.Count; ++j)
                    {

                        sel = (Option)Optionbox.Items[j];
                        if (Optionbox.GetItemChecked(Optionbox.Items.IndexOf(sel)) == true)
                            for (int i = 0; i < ph.Opts.Count; ++i)
                                if (!ph.Opts[i].Optname.Equals(sel.Optname))
                                    check = true;
                                else
                                {
                                    check = false;
                                    break;
                                }
                        else
                            check = false;

                        if (check)
                            ph.Opts.Add(sel);
                        check = true;
                    }
                    if (Optionbox.CheckedItems.Count == 0)
                        ph.Opts.Clear();
                }

                phones.Remove(ph1);
                phones.Add(ph);
                PhonesBox.SelectedIndex = PhonesBox.Items.Count - 1;
            }
        }

        private void delselect_Click(object sender, EventArgs e)
        {
            if (PhonesBox.SelectedItem != null)
            {
                Phone ph = (Phone)PhonesBox.SelectedItem;

                phones.Remove(ph);
                if (PhonesBox.Items.Count != 0)
                {
                    PhonesBox.SetSelected(0, false);
                    PhonesBox.SetSelected(0, true);
                }
                else
                    PhonesBox.SelectedItem = false;


                //удалить несколько???
            }
            if (PhonesBox.SelectedItem == null)
            {
                Option sel;
                for (int i = 0; i < Optionbox.Items.Count; ++i)
                {
                    sel = (Option)Optionbox.Items[i];
                    Optionbox.SetItemChecked(Optionbox.Items.IndexOf(sel), false);
                }
            }
        }



        private void Savetofile_Click(object sender, EventArgs e)
        {
            Serial.serial(phones, options);
            //сохранить ини
        }

        private void Readfile_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"serialphone.txt") && File.Exists(@"serialopts.txt"))
                Serial.deserial(ref phones, ref options);
            else
            {
                string readphoneini;
                string readoptini;
                myini.readini(out readphoneini, out readoptini);
                myini.parseini(readphoneini, readoptini, ref phones, ref options);
            }

            PhonesBox.DataSource = null;
            PhonesBox.DataSource = phones;
            PhonesBox.Refresh();

            //PhoneoptoinsBox.DataSource = null;
            //PhoneoptoinsBox.Refresh();
            //phoneoptionbox не работает

        }

        private void delall_Click(object sender, EventArgs e)
        {
            PhonesBox.DataSource = null;
            phones.Clear();
            if (PhonesBox.SelectedItem == null)
            {
                Option sel;
                for (int i = 0; i < Optionbox.Items.Count; ++i)
                {
                    sel = (Option)Optionbox.Items[i];
                    Optionbox.SetItemChecked(Optionbox.Items.IndexOf(sel), false);
                }
            }
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            Modeltb.Text = "";
            Ostb.Text = "";
            Procesrtb.Text = "";
            Pricetb.Text = "";
            pictureBox1.ImageLocation = "";
            PhoneoptoinsBox.Items.Clear();
            Editmodeltb.Text = "";
            Editostb.Text = "";
            Editprocsrtb.Text = "";
            Editpicpathtb.Text = "";
            Editpricetb.Text = "";
            Option sel;
            for (int i = 0; i < Optionbox.Items.Count; ++i)
            {
                sel = (Option)Optionbox.Items[i];
                Optionbox.SetItemChecked(Optionbox.Items.IndexOf(sel), false);
            }
        }

        private void Addphonebtn_Click(object sender, EventArgs e)
        {
            Phone ph = new Phone();
            if (!String.IsNullOrEmpty(Editmodeltb.Text))
                ph.Phname = Editmodeltb.Text;
            if (!String.IsNullOrEmpty(Editostb.Text))
                ph.Os = Editostb.Text;
            if (!String.IsNullOrEmpty(Editprocsrtb.Text))
                ph.Procesr = Editprocsrtb.Text;
            if (!String.IsNullOrEmpty(Editpicpathtb.Text))
                ph.Picpath = Editpicpathtb.Text;
            if (!String.IsNullOrEmpty(Editpricetb.Text))
                ph.Price = Decimal.Parse(Editpricetb.Text);

            Option sel;
            if (PhonesBox.SelectedItem != null)
            {
                for (int j = 0; j < Optionbox.Items.Count; ++j)
                {

                    sel = (Option)Optionbox.Items[j];
                    if (Optionbox.GetItemChecked(Optionbox.Items.IndexOf(sel)) == true)
                        for (int i = 0; i < ph.Opts.Count; ++i)
                            if (!ph.Opts[i].Optname.Equals(sel.Optname))
                                check = true;
                            else
                            {
                                check = false;
                                break;
                            }
                    else
                        check = false;

                    if (check)
                        ph.Opts.Add(sel);
                    check = true;
                }
                if (Optionbox.CheckedItems.Count == 0)
                    ph.Opts.Clear();
            }

            phones.Add(ph);
            PhonesBox.SelectedIndex = PhonesBox.Items.Count - 1;
        }


    }
}



