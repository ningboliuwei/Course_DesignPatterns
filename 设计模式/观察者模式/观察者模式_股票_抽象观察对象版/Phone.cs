using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者模式_股票_抽象观察对象版 {
    class Phone : Observer {
        public string PhoneNumber { get; set; }

        public override void SetSubject(Subject subject) {
            Subject = subject;
        }

        public override void Response() {
            if (Subject.GetType().ToString().Contains("Stock")) {
                Console.WriteLine(
                    $"手机 {PhoneNumber} 已收到股票 {(Subject as Stock).Symbol} 的最新价格为 {(Subject as Stock).Price}");
            }
            else if (Subject.GetType().ToString().Contains("Bond")) {
                Console.WriteLine(
                    $"手机 {PhoneNumber} 已收到债券 {(Subject as Bond).Company} 的最新价格为 {(Subject as Bond).Price}");
            }
        }
    }
}