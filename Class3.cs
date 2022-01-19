using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inharitence_class
{
  public class Class3:Class2
    {
        public string tname;

        public void setvalue(string t_name,string[]std_name,string[]clas,int[]roll,string[]subject,int[]subject_id)
        {
            this.tname = t_name;
            this.setstudent(std_name, clas, roll);
            this.setsubject(subject, subject_id);
           
            
        }
        public void getvalue()
        {

        }
    }
}
