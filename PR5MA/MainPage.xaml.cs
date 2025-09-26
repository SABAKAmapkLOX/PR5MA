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
                case "-": enResult.Text += "-"; break;
                case "+": enResult.Text += "+"; break;
                case "(": enResult.Text += "("; break;
                case ")": enResult.Text += ")"; break;
                case "DEL": enResult.Text.Remove(1); break;
            }
        }


        private void Calc()
        {
            try
            {
                DivideNumbers(enResult.Text);
                CalcNumber();
            }
            catch
            {
                enResult.Text = "ОШИБКА!!!!!!!!!!!!!";
            }
        }

        List<int> _numbers;
        List<string> _operation;

        private void DivideNumbers(string example)
        {
            _numbers = new List<int>();
            _operation = new List<string>();

            bool boolOperation = true;
            string lastNumber = "";

            for (int i = 0; i < example.Length; i++)
            {
                if (example[i] != '*' && example[i] != '+' && example[i] != '-' && example[i] != '/')
                {
                    if (boolOperation)
                    {
                        lastNumber += example[i].ToString();
                    }
                    else
                    {
                        _numbers.Add(Convert.ToInt32(lastNumber));
                        boolOperation = true;
                        lastNumber = "";
                        i--;
                    }
                }
                else
                {
                    boolOperation = false;
                    _operation.Add(example[i].ToString());
                }
            }
            _numbers.Add(Convert.ToInt32(lastNumber));
        }

        private void CalcNumber()
        {
            for (int j = 0; j < _operation.Count; j++)
            {

                if (_operation[j] == "*")
                {
                    _numbers[j] = _numbers[j] * _numbers[j + 1];
                    _numbers.RemoveAt(j + 1);
                }
                else if (_operation[j] == "/")
                {
                    _numbers[j] = _numbers[j] / _numbers[j + 1];
                    _numbers.RemoveAt(j + 1);
                }

            }

            for (int i = 0; i < _operation.Count; i++)
            {

                if (_numbers.Count == 2)
                {
                    i--;
                }

                if (_operation[i] == "-")
                {
                    _numbers[i] = _numbers[i] - _numbers[i + 1];
                    _numbers.RemoveAt(i + 1);
                }

                if (_operation[i] == "+")
                {
                    _numbers[i] = _numbers[i] + _numbers[i + 1];
                    _numbers.RemoveAt(i + 1);
                }

            }
        }
    }
}

