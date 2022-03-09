#region

using System;
using System.IO;

#endregion

namespace 实验12_观察者模式_计数器 {
    internal class FileOutputer {
        public string FilePath { get; set; }

        public void WriteCountEnd(object sender, CountEndEventArgs e) {
            File.AppendAllText(FilePath, $"计数到 {e.EndNumber} 结束{Environment.NewLine}");
        }

        public void WriteCounting(object sender, CountingEventArgs e) {
            File.AppendAllText(FilePath, $"当前计数到 {e.CurrentNumber} - {DateTime.Now}{Environment.NewLine}");
        }

        public void WriteCountStart(object sender, CountStartEventArgs e) {
            File.AppendAllText(FilePath, $"计数从 {e.StartNumber} 开始{Environment.NewLine}");
        }
    }
}