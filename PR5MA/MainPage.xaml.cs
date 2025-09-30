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

                case "=": Calc(); break;
                case "*": enResult.Text += "*"; break;
                case "/": enResult.Text += "/"; break;
                case "-": enResult.Text += "-"; break;
                case "+": enResult.Text += "+"; break;
                case "(": enResult.Text += "("; break;
                case ")": enResult.Text += ")"; break;
                case "DEL": enResult.Text = ""; break;
            }
        }


        private void Calc()
        {
            try
            {
                DivideString divideString = new DivideString();
                divideString.DivideNumbers(enResult.Text);
                //enResult.Text = CalcNumberString.CalcNumber();
            }
            catch
            {
                enResult.Text = "ОШИБКА!!!!!!!!!!!!!";
            }
        }

        
    }
}

