using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_KalitimNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Kalıtım Miras Alma Nedir?
             * Kalıtım yolu ile oluşturmuş olduğumuz nesnelerimiz birbilerinden türetilebilir ve türeyen nesne türetilen nesnenin tüm özelliklerini kullanabilir.
             * C# programlama diline başlarken tip dönüşümlerinde tüm nesneleri tanıyan her türden nesneyi kabul eden object tipinden bahsetmiştik.
             * Object tipi framework içerisindeki tüm nesnelerin atası olan bir tip olduğu için (tüm nesneler object nesnesinden kalıtıldığı için) türetilen tip kendisinden türeyen tüm tipleri tanır ve tam bir uyumluluk sağlar.
             * Ogrenci O1 = new Ogrenci();
             * Nesne örneği alınan öğrenci nesnesi aslında object tipinden türetilmiş bir nesnedir. 
             */

            //temelTip T1 = new temelTip();
            //T1.TemelTipMetot1();

            Egitmen E1 = new Egitmen();
            //Console.WriteLine("Eğitmen nesnesi örneklendi.");
            //E1.TemelTipMetot1();

            ////Özel tiplerde Boxing ve Unboxing

            ////Bizim object nesnemiz nedir?
            ///Temel Tip
            temelTip T2;
            ////Hangi nesnelerde temeltip object görevi görür...
            ///Personel Egitmen Ogrenci
            ///Temeltip nesnesinden türedikleri için temel tip nesnesi bu nesnelerde object gibi davranır.
            //T2 = E1;//Eğitmen nesnesini Temeltip nesnesine atadık.

            //E1 = (Egitmen)T2;//Unboxing

            //Personel P1 = new Personel();
            //T2 = P1;// Personel nesnesini Temeltip nesnesine atadık.

            //P1 = (Personel)T2;//Unboxing

            //Ogrenci O1 = new Ogrenci();
            //T2 = O1;//Ogrenci nesnesini Temeltip nesnesine atadık.

            //O1 = (Ogrenci)T2;//Unboxing

            //object O3 = T2;

            //Boxing - - Unboxing

            //object O1 = E1;//Boxing
            //E1 = (Egitmen)O1;//Unboxing

            //Personel P1 = new Personel();
            //P1.TemelTipMetot1();

            //Ogrenci O1 = new Ogrenci();
            //O1.TemelTipMetot1();

            //object obj1 = O1;
            //O1 = (Ogrenci)obj1;

            //obj1 = P1;
            //P1 = (Personel)obj1;

            //Ben istiyorum Kİ türemiş olan tiplerim türeyemesin...
            // object => temeltip => Personel => X
            //                    => Ogrenci => X
            //                    => Egitmen => X

            //Hangi nesnemizin kalıtılmasını istemiyoruz?
            // Egitmen sealed

            //Egitmen E1 = new Egitmen();

            //public : uygulamamızın içerisinde veya dışarısında ulaşılabilir anlamını taşır.
            //private: sadece tanımlandığı class içerisine erişilebilir olur.
            //protected: Normal kullanımda private olarak davranır. kalıtım yolu ile başka bir class içerisinde public olarak kullanılır.

            temelTip T1 = new temelTip();

            Ogrenci O1 = new Ogrenci();
            O1.TemelTipMetot1();


            Console.ReadKey();

         
        }
    }
}
