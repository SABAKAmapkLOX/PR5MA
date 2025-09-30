using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR5MA
{
    public class CalcNumberString
    {
        //Калькулируем
        public string CalcNumber(List<string> _operation, List<int> _numbers)
        {

            for (int j = 0; j < _operation.Count; j++)
            {

                if (_operation[j] == "*")
                {
                    _numbers[j] = _numbers[j] * _numbers[j + 1];
                    _numbers.RemoveAt(j + 1);
                    _operation.RemoveAt(j);
                    if (_operation.Count == 0) break;
                    j--;
                }
                else if (_operation[j] == "/")
                {
                    _numbers[j] = _numbers[j] / _numbers[j + 1];
                    _numbers.RemoveAt(j + 1);
                    _operation.RemoveAt(j);
                    if (_operation.Count == 0) break;
                    j--;
                }

            }

            for (int i = 0; i < _operation.Count; i++)
            {

                if (_operation[i] == "-")
                {
                    _numbers[i] = _numbers[i] - _numbers[i + 1];
                    _numbers.RemoveAt(i + 1);
                    _operation.RemoveAt(i);
                    if (_operation.Count == 0) break;
                    i--;
                }

                if (_operation[i] == "+")
                {
                    _numbers[i] = _numbers[i] + _numbers[i + 1];
                    _numbers.RemoveAt(i + 1);
                    _operation.RemoveAt(i);
                    if (_operation.Count == 0) break;
                    i--;
                }

            }


            return Convert.ToString(_numbers[0]);
        }
    }
}
