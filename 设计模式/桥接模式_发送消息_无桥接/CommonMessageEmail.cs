using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 桥接模式_发送消息_无桥接
{
    class CommonMessageEmail:IMessage
    {
        public void Send()
        {
            Console.WriteLine("使用电子邮件发送普通消息");
        }
    }
}
