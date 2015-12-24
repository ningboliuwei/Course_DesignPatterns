using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者模式_股票_单向组合关系版
{
    class Phone : Observer
    {
        public string PhoneNumber { get; set; }

        public override void Update(Subject subject)
        {
            if (subject.GetType().ToString().Contains("Stock"))
            {
                Console.WriteLine($"手机 {PhoneNumber} 已收到股票 {(subject as Stock).Symbol} 的最新价格为 {(subject as Stock).Price}");
            }
            else if(subject.GetType().ToString().Contains("Bond"))
            {
                Console.WriteLine($"手机 {PhoneNumber} 已收到债券 {(subject as Bond).Company} 的最新价格为 {(subject as Bond).Price}");
            }
            Console.WriteLine();
        }
    }
}