using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inharitence_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Class3 obj = new Class3();
            string tname = textBox16.Text;
            string[] student_name = new string[3];
            int[] rollno = new int[3];
            string[] clas = new string[3];
            string[] subject_name = new string[3];
            int[] subject_id = new int[3];
            student_name[0] = textBox1.Text;
            student_name[1] = textBox6.Text;
            student_name[2] = textBox11.Text;
            rollno[0] = Convert.ToInt32(textBox2.Text);
            rollno[1] = Convert.ToInt32(textBox7.Text);
            rollno[2] = Convert.ToInt32(textBox12.Text);
            clas[0] = textBox3.Text;
            clas[1] = textBox8.Text;
            clas[2] = textBox13.Text;
            subject_name[0] = textBox4.Text;
            subject_name[1] = textBox9.Text;
            subject_name[2] = textBox14.Text;
            subject_id[0] = Convert.ToInt32(textBox5.Text);
            subject_id[1] = Convert.ToInt32(textBox10.Text);
            subject_id[2] = Convert.ToInt32(textBox15.Text);

            obj.setvalue(tname, student_name, clas, rollno,subject_name,subject_id);


        }
    }
}
