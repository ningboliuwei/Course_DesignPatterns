namespace 命令模式_计算器_命令模式 {
    public class CaculatorCommand : Command {
        private readonly Caculator m_caculator;

        private int m_operand;
        private char m_optr;

        public CaculatorCommand(Caculator mCaculator, char mOptr, int mOperand) {
            m_optr = mOptr;
            m_operand = mOperand;
            m_caculator = mCaculator;
        }

        public int Operand {
            set => m_operand = value;
        }

        public char Optr {
            set => m_optr = value;
        }

        public override void Execute() {
            m_caculator.Operaion(m_optr, m_operand);
        }

        private char Undo(char optr) {
            var undo = ' ';

            switch (optr) {
                case '+':
                    undo = '-';
                    break;
                case '-':
                    undo = '+';
                    break;
                case '*':
                    undo = '/';
                    break;
                case '/':
                    undo = '*';
                    break;
            }

            return undo;
        }

        public override void UnExecute() {
            m_caculator.Operaion(Undo(m_optr), m_operand);
        }
    }
}