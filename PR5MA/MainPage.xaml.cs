namespace PR5MA
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonNumber_Clicked(object sender, EventArgs e)
        {
            var s = sender as Button;
            switch (s.Text)
            {
                case "1": enResult.Text += "1"; break;
                case "2": enResult.Text += "2"; break;
                case "3": enResult.Text += "3"; break;
                case "4": enResult.Text += "4"; break;
                case "5": enResult.Text += "5"; break;
                case "6": enResult.Text += "6"; break;
                case "7": enResult.Text += "7"; break;
                case "8": enResult.Text += "8"; break;
                case "9": enResult.Text += "9"; break;
                case "0": enResult.Text += "0"; break;
                case ",": enResult.Text += ","; break;

                case "-":
                    Calc("-");
                    break;
                case "*":
                    Calc("*");
                    break;
                case "+":
                    Calc("+");
                    break;

                case "=": Calc("="); break;
            }
        }

        double result = 0;
        double lastNumber = 0;
        string lastOne = "";

        private void Calc(string math)
        {
            if (math == "=")
            {
                if (lastNumber != 0 && lastOne == "+")
                {
                    result = lastNumber + Convert.ToDouble(enResult.Text);
                }

                if (lastNumber != 0 && lastOne == "-")
                {
                    result = lastNumber - Convert.ToDouble(enResult.Text);
                }

                if (lastNumber != 0 && lastOne == "*")
                {
                    result = lastNumber * Convert.ToDouble(enResult.Text);
                }

                enResult.Text = Convert.ToString(result);
            }
            else
            {
                lastOne = math;
                lastNumber = Convert.ToDouble(enResult.Text);
                enResult.Text = null;
            }

        }
    }
}
