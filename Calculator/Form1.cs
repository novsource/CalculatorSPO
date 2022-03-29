using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        public bool extendedActive = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void SumBtn_Click(object sender, EventArgs e)
        {
            if (FirstNumTxtBox.Text.Length != 0)
            {
                double x = Convert.ToDouble(FirstNumTxtBox.Text);
                double y = Convert.ToDouble(ResultTxtBox.Text);

                ResultTxtBox.Text = stat.CalculatorBase.Add(x, y);
            }
            
        }

        private void SubBtn_Click(object sender, EventArgs e)
        {
            if (FirstNumTxtBox.Text.Length != 0)
            {
                double x = Convert.ToDouble(FirstNumTxtBox.Text);
                double y = Convert.ToDouble(ResultTxtBox.Text);

                ResultTxtBox.Text = stat.CalculatorBase.Substract(x, y);
            }
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            if (FirstNumTxtBox.Text.Length != 0)
            {
                double x = Convert.ToDouble(FirstNumTxtBox.Text);
                double y = Convert.ToDouble(ResultTxtBox.Text);

                ResultTxtBox.Text = stat.CalculatorBase.Multiply(x, y);
            }
        }

        private void DivBtn_Click(object sender, EventArgs e)
        {
            if (FirstNumTxtBox.Text.Length != 0)
            {
                double x = Convert.ToDouble(FirstNumTxtBox.Text);
                double y = Convert.ToDouble(ResultTxtBox.Text);

                ResultTxtBox.Text = stat.CalculatorBase.Divide(x, y);
            }
        }

        private void FirstNumTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ExtendedBtn_Click(object sender, EventArgs e)
        {
            Assembly load = Assembly.Load("dyn.dll");
            Object obj = load.CreateInstance("CalculatorExtended");
            Type extend = obj.GetType("CalculatorExtended");


        }

        private void SinBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
