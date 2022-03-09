#region

using System;

#endregion

namespace 外观模式_家庭影院_外观模式版 {
    internal class Program {
        private static void Main(string[] args) {
            var remote = new Remote();

            remote.WatchMovie();

            Console.WriteLine("------------------------------");
            remote.EndMovie();
            Console.ReadKey();
        }
    }
}