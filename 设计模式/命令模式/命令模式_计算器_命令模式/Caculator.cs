#region

using System;

#endregion

namespace 命令模式_计算器_命令模式 {
    public class Caculator {
        private int _result;

        public void Operaion(char optr, int operand) {
            switch (optr) {
                case '+':
                    _result += operand;
                    break;
                case '-':
                    _result -= operand;
                    break;
                case '*':
                    _result *= operand;
                    break;
                case '/':
                    _result /= operand;
                    break;
            }

            Console.WriteLine("result is {0} (following {1} {2})", _result, optr, operand);
        }
    }
}