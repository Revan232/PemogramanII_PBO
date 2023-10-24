using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220070
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //inheritance
            anggota a = new anggota();
            a.team();
            Console.WriteLine(a.nartoh);
            Console.WriteLine(a.saske);
            Console.WriteLine(a.saku);

            Console.WriteLine("");

            //constructor
            Console.WriteLine("Kontrak Hewan");
            memanggil sumon = new memanggil { naruto = "Katak", sasuke = "Ular", sakura = "Siput" };
            Console.WriteLine(sumon.naruto);
            Console.WriteLine(sumon.sasuke);
            Console.WriteLine(sumon.sakura);

            //FieldProperty
            Console.WriteLine("");
            episode D = new episode();
            D.Episode = 500;
            Console.WriteLine("Episode");
            Console.WriteLine("Jumlah : {0}", D.Episode);

            Console.WriteLine("");
            //Polymorphism
            Console.WriteLine("Voice");
            naruto b = new naruto();
            b.audio();
            sasuke c = new sasuke();
            c.audio();
            sakura e = new sakura();
            e.audio();
        }
    }
}
