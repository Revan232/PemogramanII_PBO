using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220070
{
    internal class Polymorphism
    {
    }
    class suara
    {
        public virtual void audio()
        {
            Console.WriteLine("suara hasnya");
        }
    }

    class naruto : suara
    {
        public override void audio()
        {
            Console.WriteLine("Datebayo");
        }
    }
    class sasuke : suara
    {

        public override void audio()
        {
            Console.WriteLine(".....");
        }
    }
    class sakura : suara
    {

        public override void audio()
        {
            Console.WriteLine("syanaroo");
        }
    }
}
