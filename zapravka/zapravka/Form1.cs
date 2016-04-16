using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Wxcel = Microsoft.Office.Interop.Excel;


namespace zapravka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //litersquantity.GotFocus += litersquantity_GotFocus;
            //Amountsum.GotFocus += Amountsum_GotFocus;

        }

        //void litersquantity_GotFocus(object sender, EventArgs e)
        //{
        //    Amountsum.TextChanged -= Amountsum_TextChanged;
        //}
        //void Amountsum_GotFocus(object sender, EventArgs e)
        //{
        //    litersquantity.TextChanged -= litersquantity_TextChanged;
        //}

        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (Literscheck.Checked == true)
            {
                Litersqt.Enabled = true;
                Amountsum.Enabled = false;

            }
            else
            {
                Amountsum.Enabled = true;
                Litersqt.Enabled = false;

            }
        }

        private void Benz_TextChanged(object sender, EventArgs e)
        {
            double numb;
            double price;
            if (Fuel.Text.Contains("АИ-92"))
                Fuelprice.Text = "11000";
            else if (Fuel.Text.Contains("АИ-95"))
                Fuelprice.Text = "11900";
            else
                Fuelprice.Text = "13000";
            if (Litersqt.Text != null && Double.TryParse(Litersqt.Text, out numb)
                && Litersqt.Enabled == true)
            {
                price = Double.Parse(Fuelprice.Text);
                Amountsum.Text = (numb * price).ToString("N2");
                Topay.Text = Amountsum.Text;
            }

            if (Amountsum.Text != null && Double.TryParse(Amountsum.Text, out numb)
                && Amountsum.Enabled == true)
            {
                price = Double.Parse(Fuelprice.Text);
                Litersqt.Text = (numb / price).ToString("N2");    //формат прямо тут
                Topay.Text = Amountsum.Text;
            }
        }


        private void litersquantity_KeyUp(object sender, KeyEventArgs e)
        {
            double numb;
            double price;
            if (Double.TryParse(Litersqt.Text, out numb))
            {
                price = Double.Parse(Fuelprice.Text);
                Amountsum.Text = (numb * price).ToString("N2");
            }
            else
                Amountsum.Text = "0";
            Topay.Text = Amountsum.Text;
        }

        private void Amountsum_KeyUp(object sender, KeyEventArgs e)
        {

            double numb;
            double price;
            if (Double.TryParse(Amountsum.Text, out numb))
            {
                price = Double.Parse(Fuelprice.Text);
                Litersqt.Text = (numb / price).ToString("N2");    //формат прямо тут
                Topay.Text = Amountsum.Text;
            }
            else
            {
                Litersqt.Text = "0";
                Topay.Text = "0";
            }
        }



        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (hotdog.Checked == true)
            {
                hotdogqt.Enabled = true;
                hotdogqt.Text = "1";
            }
            else
            {
                hotdogqt.Enabled = false;
                hotdogqt.Text = "0";
            }
        }

        private void hamburg_Click(object sender, EventArgs e)
        {
            if (hamburg.Checked == true)
            {
                hamburgqt.Enabled = true;
                hamburgqt.Text = "1";

            }
            else
            {
                hamburgqt.Enabled = false;
                hamburgqt.Text = "0";
            }
        }

        private void chizburgqt_Click(object sender, EventArgs e)
        {
            if (chizburg.Checked == true)
            {
                chizburgqt.Enabled = true;
                chizburgqt.Text = "1";
            }
            else
            {
                chizburgqt.Enabled = false;
                chizburgqt.Text = "0";
            }
        }

        private void kola_Click(object sender, EventArgs e)
        {
            if (kola.Checked == true)
            {
                kolaqt.Enabled = true;
                kolaqt.Text = "1";
            }
            else
            {
                kolaqt.Enabled = false;
                kolaqt.Text = "0";
            }
        }



        private void hotdogqt_TextChanged(object sender, EventArgs e)
        {
            double sum = 0;
            if (String.IsNullOrEmpty(Kafepay.Text))
                Kafepay.Text = "0";

            if (!String.IsNullOrEmpty(hotdogqt.Text))
                sum += Double.Parse(hotdogqt.Text) * Double.Parse(hotdogprs.Text);
            if (!String.IsNullOrEmpty(hamburgqt.Text))
                sum += Double.Parse(hamburgqt.Text) * Double.Parse(hamburgprs.Text);
            if (!String.IsNullOrEmpty(chizburgqt.Text))
                sum += Double.Parse(chizburgqt.Text) * Double.Parse(chizburgprs.Text);
            if (!String.IsNullOrEmpty(kolaqt.Text))
                sum += Double.Parse(kolaqt.Text) * Double.Parse(kolaprs.Text);

            Kafepay.Text = sum.ToString();
        }

        private void topay_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Kafepay.Text))
                Kafepay.Text = "0";
            if (String.IsNullOrEmpty(Topay.Text))
                Topay.Text = "0";
            rezultsum.Text = (Double.Parse(Topay.Text) + Double.Parse(Kafepay.Text)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(rezultsum.Text) || !rezultsum.Text.Equals("0"))
                {
                    Word.Application wa = new Word.Application();
                    wa.Visible = true;
                    Word.Document zapravkadoc = new Word.Document();
                    object MyTemplate = Type.Missing;
                    // имя шаблона, по которому создаѐтся новый документ. 
                    // Если значение не указано, то используется шаблон Normal.dot;  
                    object NewTemplate = false; // при true новый документ открывается как шаблон. 
                    // Значение по умолчанию – false; 
                    object DocumentType = Word.WdNewDocumentType.wdNewBlankDocument;
                    //DocumentType – тип документа, может принимать 
                    // одно из следующих значений констант типа Word.WdNewDocumentType: 
                    // wdNewBlankDocument – документ Word (по умолчанию); 
                    // wdNewEmailMessage – электронное сообщение; 
                    // wdNewWebPage – Web-страница; 
                    // wdNewXMLDocument – XML-документ; 

                    object Visible = true; // видимость документа. 
                    // При true (по умолчанию) документ отображается.
                    zapravkadoc = wa.Documents.Add(ref MyTemplate,
                                                 ref NewTemplate,
                                                 ref DocumentType,
                                                 ref Visible);


                    object pargf = Type.Missing;
                    Word.Paragraph wp = zapravkadoc.Content.Paragraphs.Add(ref pargf);
                    // применение полужирного начертания к тексту 
                    wp.Range.Font.Bold = 1;
                    // установка размера текста
                    wp.Range.Font.Size = 20;
                    // добавление текста
                    wp.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;   
                    // выравнивание текста по центру 
                    wp.Range.Text = this.Text;
                    // вставка параграфа
                    if (!String.IsNullOrEmpty(Topay.Text))
                        if (!Topay.Text.Equals("0"))
                        {
                            wp.Range.Font.Size = 16;
                            wp.Range.Text = "ТОПЛИВО\n";

                            wp.Format.SpaceAfter = 0;
                            wp.Range.InsertParagraphAfter();
                            wp.Range.Font.Size = 14;
                            wp.Range.Text = Fueltype.Text + " : " + Fuel.Text + "\n";
                            wp.Range.Font.Size = 12;
                            wp.Range.Text = Fuelpricelb.Text + " : " + Fuelprice.Text + "\n";
                            wp.Range.Text = Literscheck.Text + " : " + Litersqt.Text + " л.\n";
                            wp.Range.Text = Amountcheck.Text + " : " + Amountsum.Text + " руб.\n";
                            wp.Range.Text = "К оплате за топливо : " + Topay.Text + " руб.\n";
                            wp.Range.Text = "\n\n";

                            wp.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                        }



                    if (!String.IsNullOrEmpty(Kafepay.Text))
                        if (!Kafepay.Text.Equals("0"))
                        {
                            wp.Range.Font.Size = 16;
                            wp.Range.Text = "КАФЕ\n";

                            wp.Format.SpaceAfter = 0;
                            wp.Range.InsertParagraphAfter();
                            wp.Range.Font.Size = 12;
                            if (hotdog.Checked == true)
                                wp.Range.Text = hotdog.Text + "  " + Kafeprices.Text + " : " + hotdogprs.Text +
                                    " руб./шт.,  " + Kafeqts.Text + " : " + hotdogqt.Text + "шт.\n";
                            if (hamburg.Checked == true)
                                wp.Range.Text = hamburg.Text + "  " + Kafeprices.Text + " : " + hamburgprs.Text +
                                    " руб./шт.,  " + Kafeqts.Text + " : " + hamburgqt.Text + "шт.\n";
                            if (chizburg.Checked == true)
                                wp.Range.Text = chizburg.Text + "  " + Kafeprices.Text + " : " + chizburgprs.Text +
                                    " руб./шт.,  " + Kafeqts.Text + " : " + chizburgqt.Text + "шт.\n";
                            if (kola.Checked == true)
                                wp.Range.Text = kola.Text + "  " + Kafeprices.Text + " : " + kolaprs.Text +
                                    " руб./шт.,  " + Kafeqts.Text + " : " + kolaqt.Text + "шт.\n";
                            wp.Range.Text = "К оплате за Супер кафе : " + Kafepay.Text + " руб.\n";
                            wp.Range.Text = "\n\n";

                            wp.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                        }

                    wp.Range.Font.Size = 16;
                    wp.Range.Text = "Итого к оплате : " + rezultsum.Text + "руб.";

                }


            foreach (var con in this.Controls)
            {
                if (con is GroupBox)
                {
                    GroupBox gr = (GroupBox)con;

                    //тут еще нужно проверять групбоксы внутри групбоксов

                    foreach (var ctr in gr.Controls)
                    {
                        if (ctr is TextBox)
                        {
                            TextBox tb = ctr as TextBox;
                            if (tb.Tag != null)
                            {
                                if ((tb.Tag.ToString()).Equals("12"))
                                    tb.ReadOnly = true;
                                if ((tb.Tag.ToString()).Equals("1") || (tb.Tag.ToString()).Equals("12"))
                                    tb.Text = "";
                            }
                        }
                        if (ctr is CheckBox)
                        {
                            CheckBox cb = ctr as CheckBox;
                            cb.Checked = false;
                        }

                    }
                }
            }


            Fuel.SelectedIndex = 0;
            Litersqt.Text = "";
            Amountsum.Text = "";
            Topay.Text = "";



            //или так
            //litersquantity.Text = "";
            //Amountsum.Text = "";
            //topay.Text = "";
            //hotdogqt.Text = "";
            //hamburgqt.Text = "";
            //chizburgqt.Text = "";
            //kolaqt.Text = "";
            //kafepay.Text = "";
            //hotdog.Checked = false;
            //hamburg.Checked = false;
            //chizburg.Checked = false;
            //kola.Checked = false;
            //hotdogqt.Enabled = false;
            //hamburgqt.Enabled = false;
            //chizburgqt.Enabled = false;
            //kolaqt.Enabled = false;

        }


    }
}
