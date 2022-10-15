using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214074_
{
    public class JavaScript : Language
    {
        protected string pageCount;

        public JavaScript(string type, string title, string pagecount) : base(type, title)
        {
            this.pageCount = pagecount;
        }

        public string PageCount
        {
            get
            {
                return pageCount;
            }
            set
            {
                pageCount = value;
            }
        }
    }
}
