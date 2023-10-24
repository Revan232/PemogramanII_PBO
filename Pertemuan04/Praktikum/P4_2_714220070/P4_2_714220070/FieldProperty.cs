using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220070
{
    internal class FieldProperty
    {
    }
    public class episode
    {
        public string nama;
        private int EPS;

        public int Episode
        {
            get { return EPS; }
            set
            {
                if (value == 500)
                    EPS = value;
            }
        }
    }
}
