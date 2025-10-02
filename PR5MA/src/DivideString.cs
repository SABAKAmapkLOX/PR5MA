using System.Text;

namespace PR5MA.src
{
    public class DivideString
    {
        List<int> _numbers;
        List<string> _operation;
        List<int> _exNumbers;
        List<string> _exOperation;

        public void DivideNumbers(string example, CalcNumberString calcNumberString)
        {
            _numbers = new List<int>();
            _operation = new List<string>();
            _exNumbers = new List<int>();
            _exOperation = new List<string>();

            bool boolOperation = true;
            string lastNumber = "";

            int parenthesisStartIndex = 0; //Начало скобок
            int parenthesisLengthIndex = 0; //Сколько нужно удалить после скобок
            //Записываем пример с скобок в list
            for (int t = 0; t < example.Length; t++)
            {

                if (example[t] == '(')
                {

                    parenthesisStartIndex = t;
                    t++;

                    for (int i = t; i < example.Length; i++)
                    {

                        if (example[i] != '*' && example[i] != '+' && example[i] != '(' && example[i] != ')' && example[i] != '-' && example[i] != '/')
                        {

                            if (boolOperation)
                            {
                                lastNumber += example[i].ToString();
                            }
                            else
                            {
                                _exNumbers.Add(Convert.ToInt32(lastNumber));
                                boolOperation = true;
                                lastNumber = "";
                                i--;
                            }

                        }
                        else
                        {
                            if (example[i] != ')')
                            {
                                boolOperation = false;
                                _exOperation.Add(example[i].ToString());
                            }
                        }


                        if (example[i] == ')')
                        {
                            break;
                        }

                        parenthesisLengthIndex++;

                    }
                }

                if (parenthesisLengthIndex > 0)
                {
                    //Добавление последнего числа и решения чего получилось
                    _exNumbers.Add(Convert.ToInt32(lastNumber));
                    CalcNumberString calcExNumberString = new CalcNumberString();
                    string exResult = calcExNumberString.CalcNumber(_exOperation, _exNumbers);

                    // Замена в example примера в скобках на решенный пример
                    StringBuilder stringBuilder = new StringBuilder(example);
                    stringBuilder.Remove(parenthesisStartIndex, parenthesisLengthIndex);
                    stringBuilder.Insert(parenthesisStartIndex, exResult);
                    example = stringBuilder.ToString();
                    parenthesisStartIndex = 0;
                    parenthesisLengthIndex = 0;
                    t = 0;
                }

            }


            lastNumber = "";
            boolOperation = true;
            //Разбиение string на числа и знаки
            for (int i = 0; i < example.Length; i++)
            {
                if (example[i] != '*' && example[i] != '+' && example[i] != '(' && example[i] != ')' && example[i] != '-' && example[i] != '/')
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
                else if (example[i] != '(' && example[i] != ')')
                {
                    boolOperation = false;
                    _operation.Add(example[i].ToString());
                }
            }
            //Добавление последнего числа и решения чего получилось
            _numbers.Add(Convert.ToInt32(lastNumber));
            calcNumberString.CalcNumber(_operation, _numbers);
        }
    }
}
