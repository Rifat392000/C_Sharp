using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanySolution
{
    public partial class Form2 : Form
    {
        CompanyDBDataContext db;
        List<employee> emp;
        int rno = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            db = new CompanyDBDataContext();
            emp =db.employees.ToList();
            showData();
        }

        private void showData()
        {
            textBox1.Text = emp[rno].eno.ToString();
            textBox2.Text = emp[rno].ename;
            textBox3.Text = emp[rno].job;
            textBox4.Text = emp[rno].salary.ToString();
            textBox5.Text = emp[rno].dname;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rno > 0)
            {
                rno -= 1;
                showData(); 
            }
            else
            {
                MessageBox.Show("First Record of the Table");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(rno<emp.Count - 1)
            {
                rno += 1;
                showData();
            }
            else
            {
                MessageBox.Show("NO MORE DATA EXISTS");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
