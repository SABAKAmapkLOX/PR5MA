using PR5MA.src;

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

                case "-":
                    enResult.Text += "-";
                    Pricol();
                    break;

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
                CalcNumberString calcNumberString = new CalcNumberString();
                divideString.DivideNumbers(enResult.Text , calcNumberString);
                enResult.Text = Convert.ToString(calcNumberString.result);
            }
            catch
            {
                enResult.Text = "ОШИБКА!!!!!!!!!!!!!";
            }
        }

        async private void Pricol()
        {
            if (enResult.Text[0] == '-')
            {
                bool result = await DisplayAlert("Купите полную версию", "Для того что бы ввести отрицательное число купите PRO калькулятор \n За 19999р", "Мечтаю купить", "Нет");
                if (result) enResult.Text = "Мы вас обманули";
                else return;
            }
        }
    }
}

