using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace 职责链模式_请假_传统
{
    class Program
    {
        private enum ManagerLevel
        {
            CommonManager, //项目经理

            MajorManager, //部门经理

            GeneralManager //总经理
        }

        private static void Main(string[] args) {
            Request request = new Request("Tom", "加薪", "我表弟结婚", 3);
            GetResult(ManagerLevel.CommonManager, request); //请假直接提交给项目经理
            GetResult(ManagerLevel.MajorManager, request); //请假直接提交给部门经理
            GetResult(ManagerLevel.GeneralManager, request); //请假直接提交给总经理
            Console.ReadLine();
        }

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
    }
}