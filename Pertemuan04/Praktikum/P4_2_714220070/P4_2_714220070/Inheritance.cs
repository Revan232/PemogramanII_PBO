using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220070
{
    internal class Inheritance
    {
    }
    public class team_7
    {
        public string nartoh { get; set; }
        public string saske { get; set; }

        public string saku  { get; set; }

        public void team()
        {
            Console.WriteLine("Team 7");
        }
    }
    class anggota : team_7
    {
        public anggota()
        {
            nartoh = "Uzumaki Naruto";
            saske = "Uchiha Sasuke";
            saku = "Haruno Sakura";
        }
       


    }
}
