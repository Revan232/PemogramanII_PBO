using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_3_714220070
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Menu Perhitungan persegi panjang");
                Console.WriteLine("1. Hitung nilai luas");
                Console.WriteLine("2. Hitung nilai keliling");

                Console.Write("Menu Pilihan: ");
                int input_menu = Convert.ToInt32(Console.ReadLine());

                if (input_menu == 1)
                {
                    Console.WriteLine("Menghitung luas persegi panjang");
                    Console.Write("Masukkan panjang: ");
                    int panjang = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Masukkan lebar: ");
                    int lebar = Convert.ToInt32(Console.ReadLine());

                    int luas = panjang * lebar;
                    Console.WriteLine("Luas dari Persegi Panjang = {0}", luas);
                }

                else if (input_menu == 2)
                {
                    Console.WriteLine("Menghitung Keliling persegi panjang");
                    Console.Write("Masukkan Panjang: ");
                    int panjang = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Masukkan lebar: ");
                    int lebar = Convert.ToInt32(Console.ReadLine());

                    int keliling = 2 * (panjang + lebar);
                    Console.WriteLine("Luas dari Persegi Panjang = {0}", keliling);
                }

                else
                {
                    Console.WriteLine("Menu tidak tersedia");
                }
                Console.Write("\nIngin mengulang kembali? (Y/T)");
            }
            while (Console.ReadLine() == "Y");
        }
    }
}