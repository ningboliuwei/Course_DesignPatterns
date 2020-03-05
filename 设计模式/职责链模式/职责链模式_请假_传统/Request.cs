using System;
using System.Collections.Generic;
using System.Text;

namespace 职责链模式_请假_传统
{
    public class Request
    {
        //申请人
        public string Name { get; set; }

        //申请类别
        public string RequestType { get; set; }

        //申请内容
        public string RequestContent { get; set; }

        //申请数量
        public int Number { get; set; }

        public Request(string name, string requestType, string requestContent, int number) {
            Name = name;
            RequestType = requestType;
            RequestContent = requestContent;
            Number = number;
        }
    }
}