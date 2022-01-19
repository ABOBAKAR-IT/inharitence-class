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
    public partial class Form2 : Form
    {
        public Form2(Class3 obj)
        {
            InitializeComponent();

            textBox1.Text=obj.name[0];
            textBox6.Text = obj.name[1];
            textBox11.Text = obj.name[2];
           
           textBox2.Text= Convert.ToString(obj.roll[0]);
            textBox7.Text = Convert.ToString(obj.roll[1]);
            textBox12.Text = Convert.ToString(obj.roll[2]);
            textBox3.Text = obj.clas[0];
            textBox8.Text = obj.clas[1];
            textBox13.Text = obj.clas[2];

            textBox4.Text = obj.subject[0];
            textBox9.Text = obj.subject[1];
            textBox14.Text = obj.subject[2];

            textBox5.Text = Convert.ToString(obj.subject_id[0]);
            textBox10.Text = Convert.ToString(obj.subject_id[1]);
            textBox15.Text = Convert.ToString(obj.subject_id[2]);

            textBox16.Text = obj.tname;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }
    }
}
