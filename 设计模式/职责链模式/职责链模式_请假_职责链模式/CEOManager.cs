﻿using System;
using System.Collections.Generic;
using System.Text;

namespace 职责链模式_请假_职责链模式
{
    class CEOManager : Manager
    {
        public override void HandleRequest(Request request) {
            if (request.Type == "请假" || request.Type == "加薪") {
                Console.WriteLine($"{Name}：我全部批准");
            }
            else {
                if (Superior != null) {
                    Console.WriteLine(
                        $"{this.Name}:{request.Name}的{request.Content}{request.Type}申请 数量{request.Number} 无权处理，交给上级");
                    Superior.HandleRequest(request);
                }
            }
        }

        public CEOManager(string name) : base(name) {
        }
    }
}

