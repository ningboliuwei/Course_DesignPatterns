#region

using System;
using System.Collections;

#endregion

namespace 命令模式_遥控汽车 {
    internal class Program {
        private static void Main(string[] args) {
            var mycar1 = new Car();
            Console.WriteLine("--------Seperate方式执行效果如下----------");
            Console.WriteLine("请输入下一步操作(str,f,b,stp,u,exit):");
            var CarOperation = Console.ReadLine();
            var CarState = new ArrayList(); //Record state

            CarSeperateCommand carStart = new StartCommand(mycar1, CarState);
            CarSeperateCommand carMoveForwards = new MoveForwardsCommand(mycar1, CarState);
            CarSeperateCommand carMoveBackwards = new MoveBackwardsCommand(mycar1, CarState);
            CarSeperateCommand carStop = new StopCommand(mycar1, CarState);
            CarSeperateCommand carUndo = new UnDoCommand(mycar1, CarState);
            var carInvoker = new CarSeperateInvoker(carStart, carMoveForwards, carMoveBackwards, carStop, carUndo);

            while (CarOperation != "exit") {
                switch (CarOperation.ToLower()) {
                    case "str": //启动
                        carInvoker.Start();
                        Console.WriteLine("Start Operation:" + mycar1._curStateStr);

                        break;

                    case "f": //前进
                        carInvoker.MoveForwards();
                        Console.WriteLine("MoveForwards Operation:" + mycar1._curStateStr);

                        break;
                    case "b": //后退
                        carInvoker.MoveBackwards();
                        Console.WriteLine("MoveBackwards Operation:" + mycar1._curStateStr);

                        break;
                    case "stp": //停止
                        carInvoker.Stop();
                        Console.WriteLine("Stop Operation:" + mycar1._curStateStr);
                        break;
                    case "u": //回退操作
                        carInvoker.Undo();
                        Console.WriteLine("Undo Operation:" + mycar1._curStateStr);
                        break;

                    default:

                        Console.WriteLine("命令输入错误:");

                        break;
                }

                Console.WriteLine("请输入下一步操作(str,f,b,stp,u,exit):");

                CarOperation = Console.ReadLine();
            }

            Console.ReadLine();
            //Car mycar2 = new Car();
            //CarCombineCommandAll ca = new CarCombineCommandAll(mycar2);

            //Console.WriteLine("--------Combine方式执行效果如下----------");
            //ca.Start();
            //ca.MoveForwards();
            //ca.MoveBackwards();
            //ca.Stop();
            //Console.ReadLine();
        }
    }
}