#region

using System;

#endregion

namespace 装饰模式_增加属性_坦克大战 {
    internal class Program {
        private static void Main(string[] args) {
            var tank = new Tank();

            //tank.BeAttacked();
            //tank.BeAttacked();
            //tank.BeAttacked();
            //tank.BeAttacked();
            //tank.BeAttacked();

            Console.WriteLine("[吃了护盾]");
            var shield = new Shield(tank);

            shield.BeAttacked();
            shield.BeAttacked();
            shield.BeAttacked();
            shield.BeAttacked();
            shield.BeAttacked();
            shield.BeAttacked();
            shield.BeAttacked();
            shield.BeAttacked();

            tank.Move(); //没吃船之前的移动

            Console.WriteLine("[吃了船]");
            var boat = new Boat(shield);
            boat.Move(); //吃了船之后的移动

            Console.WriteLine("[船的时间到了]");
            boat.LeftTime = -1;
            boat.Move(); //船消失之后的移动

            Console.WriteLine("[吃了钟]");
            var clock = new Clock(boat);
            clock.Move();

            Console.WriteLine("[冻结的时间到了]");
            clock.LeftTime = -1;
            clock.Move();

            clock.BeAttacked();
            clock.BeAttacked();

            Console.ReadLine();
        }
    }
}