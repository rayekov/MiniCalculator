using System.Globalization;

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
           // set the globalization to en-US
            CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
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
        private void btnOperator_click( object sender, EventArgs e )
        {
            Button button = (Button)sender;
            operatorValue = button.Text;

            //if "-" operator is pressed in order to enter a negative number, show "-" on screen
            if (operatorValue=="-" && txtBoxDisplay.Text=="0")
            {
                txtBoxDisplay.Text = "-";
            }
            else
            {
                displayValue = double.Parse(txtBoxDisplay.Text);
                _ = true;
                labelDisplay.Text = displayValue + "" + operatorValue;
            }

            
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
                    {
                        //  if the user tries to divide by zero, an exception is thrown
                        if (Convert.ToInt64(txtBoxDisplay.Text) == 0) 
                        {
                            throw new Exception("MATH ERROR : Cannot divide by zero");
                        }

                        txtBoxDisplay.Text = (displayValue / double.Parse(txtBoxDisplay.Text)).ToString();

                    }
                    catch (Exception ex)
                    {
                        // we catch the exception and show the error message on the screen
                        txtBoxDisplay.Clear();
                        labelDisplay.Text = ex.Message;
                    }
                    
                    break;
                case "%":
                    txtBoxDisplay.Text = (displayValue % double.Parse(txtBoxDisplay.Text)).ToString();
                    break;

                case "sqrt":
                    try
                    {
                        if (double.Parse(txtBoxDisplay.Text) < 0)
                        {
                            throw new Exception("MATH ERROR: Only positive numbers");
                        }
                        string typedNumber = txtBoxDisplay.Text;
                        txtBoxDisplay.Text = Math.Sqrt(double.Parse(txtBoxDisplay.Text)).ToString();
                        labelDisplay.Text = "Sqrt(" + typedNumber + ")";

                    }
                    catch (Exception ex)
                    {

                        // we catch the exception and show the error message on the screen
                        txtBoxDisplay.Clear();
                        labelDisplay.Text = ex.Message;
                    }
                    
                    break;

                default:
                    txtBoxDisplay.Clear();
                    labelDisplay.Text = "SYSTEM FAILURE : UNKNOWN OPERATION";
                    break;
            }
         
            
        }
    }
}
