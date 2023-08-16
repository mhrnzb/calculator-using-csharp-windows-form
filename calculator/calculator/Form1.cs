using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        ICalculate calculate; 

        public Form1()
        {
            InitializeComponent();
            calculate = new Calculate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int sum = calculate.Plus((int)txtNumber1.Value , (int)txtNumber2.Value);
                MessageBox.Show("Sum is : " + sum);
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {//minus
            if (ValidateInputs())
            {
                int Minus = calculate.Minus(int.Parse(txtNumber1.Value.ToString()), int.Parse(txtNumber2.Value.ToString()));
                MessageBox.Show("Minus is :" + Minus);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {//divide
            if (ValidateInputs())
            {
                int divide = calculate.Devide((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("divide is : " + divide);
            }
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int multiple = calculate.Multiple((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("multiple is : " + multiple);
            }
        }

        bool ValidateInputs()
        {
            bool isValid = true;
            
            if (txtNumber1.Value == 0)
            {
                isValid = false;
                MessageBox.Show("لطفا عدد اول را وارد کنید ");
            }
            else
            {
                if (txtNumber2.Value == 0)
                {
                    isValid=false;
                    MessageBox.Show("لطفا عدد دوم را وارد کنید ");
                }
            }

            return isValid;
        }
    }
}
