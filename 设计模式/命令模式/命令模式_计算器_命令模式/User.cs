#region

using System;
using System.Collections.Generic;

#endregion

namespace 命令模式_计算器_命令模式 {
    internal class User {
        private int current;
        private readonly Caculator m_caculator = new Caculator();

        private readonly List<Command> m_commands = new List<Command>();

        public void Compute(char optr, int operand) {
            Command command = new CaculatorCommand(m_caculator, optr, operand);
            command.Execute();

            m_commands.Add(command);
            current++;
        }

        public void Redo(int levels) {
            Console.WriteLine("---Redo {0} levels", levels);

            for (var i = 0; i < levels; i++) {
                if (current < m_commands.Count - 1) {
                    m_commands[current++].Execute();
                }
            }
        }

        public void Undo(int levels) {
            Console.WriteLine("---Undo {0} levels", levels);

            for (var i = 0; i < levels; i++) {
                if (current > 0) {
                    m_commands[--current].UnExecute();
                }
            }
        }
    }
}