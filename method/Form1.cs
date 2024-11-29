using System.Web;

namespace method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string age = txtAge.Text;
            double height = 0;
            double weight = 0;
            /*if (double.TryParse(txtHeight.Text,out height)==false)
            {
                MessageBox.Show("Please input only number!!!", "Error");
                return;
            }
            if (double.TryParse(txtWeight.Text, out weight) == false)
            {
                MessageBox.Show("Please input only number!!!", "Error");
                return;
            } */
            //double height = Convert.ToDouble(txtHeight.Text); ;
            //double weight = Convert.ToDouble(txtWeight.Text); ;
            //double bmi = weight / Math.Pow(height / 100, 2);
            if (CheckDouble(txtWeight, txtHeight))
            {
                height = Convert.ToDouble(txtHeight.Text); ;
                weight = Convert.ToDouble(txtWeight.Text); ;
            }
            double bmi = BMI(height,weight);
            lblResult.Text = bmi.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("ยินดีต้อนรับ", "โปรแกรมทดสอบความอ้วนผอม");
            ClearForm();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtAge.TextAlign = HorizontalAlignment.Right;
            txtHeight.TextAlign = HorizontalAlignment.Right;
            txtWeight.TextAlign = HorizontalAlignment.Right;
            txtName.Text = string.Empty;
            txtAge.Text = "0";
            txtWeight.Text = "0";
            txtHeight.Text = "0";
            txtName.Focus();
        }
        private void InputValueData(TextBox name, TextBox age)
        {
            if (name.Text.Length != 0)
            {
                name.ForeColor = Color.DarkGreen;
            }
            else
            {
                name.ForeColor = Color.Black;
            }
            if (Convert.ToInt32(age.Text) > 0)
            {
                age.ForeColor = Color.DarkGreen;
            }
            else
            {
                age.ForeColor = Color.Black;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            InputValueData(txtName, txtAge);
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            InputValueData(txtName, txtAge);
        }
        private double BMI(double h, double w)
        {
            double bmi = w / Math.Pow(h / 100, 2);
            return bmi;
            //return w / Math.Pow(h/100, 2);
        }
        private bool CheckDouble(TextBox txtw,TextBox txth)
        {
            double w = 0;
            double h = 0;
            if (!double.TryParse(txtw.Text, out w) || !double.TryParse(txth.Text, out h))
            {
                MessageBox.Show("Please input only number!!!", "Error");
                return false;
            }
            return true;
        }
    }
}
