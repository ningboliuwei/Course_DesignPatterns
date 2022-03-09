#region

using System;

#endregion

namespace 职责链模式_请假_职责链模式 {
    internal class GeneralManager : Manager {
        public GeneralManager(string name) : base(name) {
        }

        public override void HandleRequest(Request request) {
            if (request.Type == "请假" && request.Number < 10) {
                Console.WriteLine(
                    $"{Name}:{request.Name}的{request.Content}{request.Type}申请 数量{request.Number} 被批准");
            }
            else if (request.Type == "加薪" && request.Number <= 500) {
                Console.WriteLine(
                    $"{Name}:{request.Name}的{request.Content}{request.Type}申请 数量{request.Number} 被批准");
            }
            else if (request.Type == "加薪" && request.Number > 500) {
                Console.WriteLine(
                    $"{Name}:{request.Name}的{request.Content}{request.Type}申请 数量{request.Number} 再说吧");
            }
            else {
                if (Superior != null) {
                    Console.WriteLine(
                        $"{Name}:{request.Name}的{request.Content}{request.Type}申请 数量{request.Number} 无权处理，交给上级");

                    Superior.HandleRequest(request);
                }
            }
        }
    }
}