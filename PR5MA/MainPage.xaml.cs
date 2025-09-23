using System.Data;
using System.Text.RegularExpressions;

namespace PR5MA
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        public int number = 0;

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
                Numbers(enResult.Text);
            }
            catch
            {
                enResult.Text = "ОШИБКА!!!!!!!!!!!!!";
            }
        }

        private void Numbers(string example)
        {
            List<int> numbers = new List<int>();
            List<string> operation = new List<string>();

            bool boolOperation = false;
            int lastNumber = 0;

            for (int i = 0; i < example.Length; i++)
            {
                if(example[i] != '*' && example[i] != '+' && example[i] != '-' && example[i] != '/')
                {
                    if (boolOperation)
                    {
                        lastNumber += int.Parse(example[i].ToString());
                    }
                    numbers.Add(int.Parse(example[i].ToString()));
                }
                else
                {
                    operation.Add(example[i].ToString());
                }
            }
            int c = 0;
        }
    }
}
