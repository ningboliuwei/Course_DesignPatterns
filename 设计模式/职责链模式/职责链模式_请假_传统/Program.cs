#region

using System;

#endregion

namespace 职责链模式_请假_传统 {
    internal class Program {
        private static void GetResult(ManagerLevel managerLevel, Request request) {
            if (managerLevel == ManagerLevel.CommonManager) {
                if (request.RequestType == "请假" && request.Number <= 2) {
                    Console.WriteLine("{0} : {1} 数量 {2} 被批准", request.Name, request.RequestContent, request.Number);
                }
                else {
                    Console.WriteLine("{0} : {1} 数量 {2} 我无权处理", request.Name, request.RequestContent, request.Number);
                }
            }
            else if (managerLevel == ManagerLevel.MajorManager) {
                if (request.RequestType == "请假" && request.Number <= 5) {
                    Console.WriteLine("{0} : {1} 数量 {2} 被批准", request.Name, request.RequestContent, request.Number);
                }
                else {
                    Console.WriteLine("{0} : {1} 数量 {2} 我无权处理", request.Name, request.RequestContent, request.Number);
                }
            }
            else if (managerLevel == ManagerLevel.GeneralManager) {
                if (request.RequestType == "请假") {
                    Console.WriteLine("{0} : {1} 数量 {2} 被批准", request.Name, request.RequestContent, request.Number);
                }
                else if (request.RequestType == "加薪" && request.Number <= 500) {
                    Console.WriteLine("{0} : {1} 数量 {2} 被批准", request.Name, request.RequestContent, request.Number);
                }
                else if (request.RequestType == "加薪" && request.Number > 500) {
                    Console.WriteLine("{0} : {1} 数量 {2} 再说吧", request.Name, request.RequestContent, request.Number);
                }
            }
        }

        private static void Main(string[] args) {
            var request = new Request("Tom", "加薪", "我表弟结婚", 3);
            GetResult(ManagerLevel.CommonManager, request); //请假直接提交给项目经理
            GetResult(ManagerLevel.MajorManager, request); //请假直接提交给部门经理
            GetResult(ManagerLevel.GeneralManager, request); //请假直接提交给总经理
            Console.ReadLine();
        }

        private enum ManagerLevel {
            CommonManager, //项目经理

            MajorManager, //部门经理

            GeneralManager //总经理
        }
    }
}