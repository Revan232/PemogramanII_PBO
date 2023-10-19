using P4_1_714220070;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714220070
{
    public class Book_714220070 : Product_714220070
    {
        protected string pagecount;

        public Book_714220070(string type, string title, string pagecount) : base(type, title)
        {
            this.pagecount = pagecount;
        }
        public string PageCount
        {
            get
            {
                return this.pagecount;
            }
            set
            {
                pagecount = value;
            }
        }

    }
}