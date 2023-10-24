using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220070
{
    internal class Construktor
    {
    }
    public class memanggil
    {
        public string naruto;
        public string sasuke;
        public string sakura;


        public memanggil()
        {
            this.naruto = "Katak";
            this.sasuke = "Ular";
            this.sakura = "Siput";

        }
        public memanggil(string naruto, string sasuke, string sakura)
        {
            this.naruto = naruto;
            this.sasuke= sasuke;
            this.sakura = sakura;


        }
    }
}
