using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CubeDemo;

namespace classobjectdemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Employee
        {
            int salary;
            int bonus;

            public void totalsalary (int salary1,int bonus1)
            {
                salary=salary1;
                bonus=bonus1;
                MessageBox.Show("The total salary is " + (salary + bonus));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.totalsalary(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));    


        }

        private void button2_Click(object sender, EventArgs e)
        {
            CubeExample obj = new CubeExample();
          MessageBox.Show("The cube  is "+obj.FindCube(4));
        }
    }
}
