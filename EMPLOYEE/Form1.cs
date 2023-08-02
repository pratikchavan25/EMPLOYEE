using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMPLOYEE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblsalary_Click(object sender, EventArgs e)
        {

        }

        private void lblhra_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>() { "HR", "Admin", "Maintenance", "Sales", "Security" };
            cmbdept.DataSource = list;
        }

        private void lblbtn1_Click(object sender, EventArgs e)
        {
            double bs  = Convert.ToDouble(textsalary.Text);
            double hra = bs * 0.50;
            double da = bs * 0.20;
            double ta = bs * 0.10;
            double pf = bs * 0.15;

            double gross = (bs + hra + da + ta) - pf;

            texthra.Text = hra.ToString();
            textda.Text = da.ToString();
            textta.Text = ta.ToString();
            textpf.Text = pf.ToString();
            textgrosssalary.Text = gross.ToString();
        }

        private void lblbtn3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Id={textid.Text}\nName={textname.Text}\nDepartment Name={cmbdept.Text}\nBasic Salary={textsalary.Text}\nGross Salary={textgrosssalary.Text}");
        }
    }
}
