#region

using System;
using System.Collections.Generic;
using System.IO;

#endregion

namespace 命令模式_自定义功能键_命令队列版 {
    internal class CommandQueue {
        private readonly List<Command> m_commands = new List<Command>();

        public void Add(Command command) {
            m_commands.Add(command);
        }

        public void Execute() {
            foreach (var command in m_commands) {
                command.Execute();
            }
        }

        public void Remove(Command command) {
            m_commands.Remove(command);
        }

        //增加日志功能开始
        public void WriteToLog(string filePath) {
            var writer = new StreamWriter(filePath);
            var content = "";

            foreach (var command in m_commands) {
                content += command.GetType() + Environment.NewLine;
            }

            writer.WriteLine(content);
            writer.Close();
        }
        //增加日志功能结束
    }
}