#region

using System;

#endregion

namespace 命令模式_游戏手柄_面向对象版 {
    public class Player {
        public void PassInTheAir() {
            Console.WriteLine("空中传球");
        }

        public void PassOnTheGround() {
            Console.WriteLine("地面传球");
        }

        public void PassStraight() {
            Console.WriteLine("直传球");
        }

        public void Shoot() {
            Console.WriteLine("射门");
        }
    }
}