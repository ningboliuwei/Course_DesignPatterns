#region

using System;

#endregion

namespace 命令模式_游戏手柄_面向对象版 {
    internal class Program {
        private static void ActionByKey(Player player, string key) {
            if (key == "A") {
                player.PassOnTheGround();
            }
            else if (key == "B") {
                player.PassInTheAir();
            }
            else if (key == "X") {
                player.Shoot();
            }
            else if (key == "Y") {
                player.PassStraight();
            }
        }

        private static void Main(string[] args) {
            var player1 = new Player();
            var player2 = new Player();

            var key1 = "X";
            var key2 = "B";

            Console.Write("Player1: ");
            ActionByKey(player1, key1);
            Console.Write("Player2: ");
            ActionByKey(player2, key2);

            Console.ReadLine();
        }
    }
}