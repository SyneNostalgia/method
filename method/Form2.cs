using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace method
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //txtResult.Text = Triangle(5);
            //txtResult.Text = Triangle("A", 9);
            txtResult.Text = Triangle("B");
            //txtResult.Text = Triangle();
        }
        string Triangle(int size)
        {
            string txtResult = "";
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    txtResult += "*";
                }
                txtResult += Environment.NewLine;
            }
            return txtResult;
        }
        string Triangle(string letter,int size=5)
        {
            string txtResult = "";
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    txtResult += letter;
                }
                txtResult += Environment.NewLine;
            }
            return txtResult;
        }
        /*string Triangle(string letter)
        {
            string txtResult = "";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    txtResult += letter;
                }
                txtResult += Environment.NewLine;
            }
            return txtResult;
        }*/
        string Triangle()
        {
            string txtResult = "";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    txtResult += "*";
                }
                txtResult += Environment.NewLine;
            }
            return txtResult;
        }
    }
}
