using P4_1_714220070;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714220070
{
    public class DVD_714220070 : Product_714220070
    {
        protected string _duration;
        public DVD_714220070(string title, string duration)
        {
            this.MyTitle = title;
            this.Mytype = "DVD";
            this._duration = duration;

            Console.WriteLine("DVD constructor called");

        }
        public string Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                _duration = value;
            }
        }



    }
}