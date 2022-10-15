using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214074_
{
    public class Language
    {
        private int myAngka;
        private string myType;
        private string myTitle;

        public Language()
        {

        }

        public Language (string type, string title)
        {
           this.myType = type;  
           this.myTitle = title;   
        }

        public string MyType
        {
            get
            {
                return myType;
            }
            set
            {
                myType = value;
            }
        }

        public string MyTitle
        {
            get
            {
                return myTitle;
            }
            set
            {
                myTitle = value;
            }
        }
    }
}
