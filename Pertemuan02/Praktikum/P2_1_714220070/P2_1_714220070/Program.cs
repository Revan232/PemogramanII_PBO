using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_714220070
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Masukan Angka :");

            Console.WriteLine(" Angka 1:");
            int angka1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Angka 2:");
            int angka2 = Convert.ToInt32(Console.ReadLine());

           int tambah = angka1 + angka2;
            int kurang = angka1 -angka2;
            int kali = angka1 * angka2;
            float bagi = (float)angka1 /angka2;

            Console.WriteLine("{0} + {1} = {2}", angka1, angka2, tambah);
            Console.WriteLine("{0} - {1} = {2}", angka1, angka2, kurang);
            Console.WriteLine("{0} X {1} = {2}", angka1, angka2, kali);
            Console.WriteLine("{0} : {1} = {2}", angka1, angka2, bagi);






        }
    }
}
