using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inharitence_class
{
    class Class1
    {
        protected string []name=new string[3];
        protected int[] roll=new int[3];
        protected string[] clas=new string[3];
        public void setstudent(string[]name,string[]clas,int[]roll)
        {
            this.name = name;
            this.roll = roll;
            this.clas = clas;
        }
        public void getstudent()
        {

        }
    }
   
}
