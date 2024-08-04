using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    //Abstract Olarak BasePerson class ını tanımlıyoruz.New ile türetilemez. Sadece Miras alınabilir
    // Define the abstract BasePerson class. It cannot be instantiated with 'new'. It can only be inherited.
    public abstract class BasePerson
    {
        //Propert ve field tanımları
        public string PersonName { get; set; }
        public string PersonSurname { get; set; }
        //Methota virtual anahtar kelimesini ekleyerek bu methodun miras alınan yerlerde özelleştirilmesini sağlıyoruz.
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Adınız : {PersonName}\nSoyadınız : {PersonSurname}");
        }
    }//End abstract class BasePerson
    //BasePerson dan türetilmiş Student class 
    public class Student : BasePerson
    {
        public string StudentNumber { get; set; }
        //Method u override ederek hem ana özelliklerini aldık buna ek olarak da aşağıda bu class a ait öğrenci numarası özelliğini yazdırdık.
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Öğrenci Numarası : {StudentNumber} ");
        }
    }//end class Student

    public class Teacher : BasePerson
    {
        public decimal Salary { get; set; }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Maaş Miktarı : {Salary} ");
        }
    }
}
