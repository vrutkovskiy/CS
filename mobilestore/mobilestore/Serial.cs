using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.ComponentModel;

namespace mobilestore
{
    [Serializable]
    public class Serial
    {
        public Serial()
        { }
        public static void serial(BindingList<Phone> phones, BindingList<Option> options)
        {
            using (FileStream filo = new FileStream(@"serialphone.txt", FileMode.Create, FileAccess.Write))
            {
                BinaryFormatter binForm = new BinaryFormatter();
                binForm.Serialize(filo, phones);
            }
            using (FileStream filo = new FileStream(@"serialopts.txt", FileMode.Create, FileAccess.Write))
            {
                BinaryFormatter binForm = new BinaryFormatter();
                binForm.Serialize(filo, options);
            }        
        }
        public static void deserial(ref BindingList<Phone> phones, ref BindingList<Option> options)
        {
            //BiList<PC> coll = new List<PC>(4); // десериализация объекта
            using (FileStream filo = new FileStream(@"serialphone.txt", FileMode.Open))
            {
                BinaryFormatter binForm = new BinaryFormatter();
                phones = (BindingList<Phone>)binForm.Deserialize(filo);
            }
            using (FileStream filo = new FileStream(@"serialopts.txt", FileMode.Open))
            {
                BinaryFormatter binForm = new BinaryFormatter();
                options = (BindingList<Option>)binForm.Deserialize(filo);
            }
        }
    }
}
