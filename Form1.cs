namespace MiniCalculator
{
    public partial class Calculator : Form
    {
        string operatorValue = "";
        double displayValue = 0;
        bool _ = false;
        public Calculator()
        {
            InitializeComponent();
        }
        private void btnDigit_Click(object sender, EventArgs e)
        {
            if (txtBoxDisplay.Text == "0" || _)
                txtBoxDisplay.Clear();
            _ = false;
            Button button = (Button)sender;
            txtBoxDisplay.Text += button.Text;
        }

        private void btnDigitCE_Click(object sender, EventArgs e)
        {
            txtBoxDisplay.Text = "0";
            labelDisplay.Text = "...";
        }

        private void btnDigitAC_Click(object sender, EventArgs e)
        {
            txtBoxDisplay.Clear();
            operatorValue = "0";
            labelDisplay.Text = null;
        }
        private void btnOperator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operatorValue = button.Text;
            displayValue = double.Parse(txtBoxDisplay.Text);
            _ = true;
            labelDisplay.Text = displayValue + "" + operatorValue;
        }
        private void btnOperatorEqual_click(object sender, EventArgs e)
        {
            labelDisplay.Text += txtBoxDisplay.Text;

            switch (operatorValue)
            {
                case "+":
                    txtBoxDisplay.Text = (displayValue + double.Parse(txtBoxDisplay.Text)).ToString();
                    break;

                case "-":
                    txtBoxDisplay.Text = (displayValue - double.Parse(txtBoxDisplay.Text)).ToString();
                    break;

                case "x":
                    txtBoxDisplay.Text = (displayValue * double.Parse(txtBoxDisplay.Text)).ToString();
                    break;

                case "/":
                    try
                    {if (Convert.ToInt64(txtBoxDisplay.Text) == 0)
                        throw new Exception("MATH ERROR : Cannot divide by zero");

                        txtBoxDisplay.Text = (displayValue / double.Parse(txtBoxDisplay.Text)).ToString();

                    }
                    catch (Exception ex)
                    {
                        txtBoxDisplay.Clear();
                        labelDisplay.Text = ex.Message;
                    }
                    
                    break;
            }
         
            
        }
       
    }
}
