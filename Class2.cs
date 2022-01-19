using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inharitence_class
{
    class Class2 : Class1
    {
        protected string[] subject=new string[3];
        protected int[] subject_id=new int[3];
      
        public void setsubject(string[] subject,int[] subjectid)
        {
            this.subject = subject;
            this.subject_id = subjectid;
        }
        public void getsubject(string[]subject,int[]subjectid)
        {

        }
    }
}
