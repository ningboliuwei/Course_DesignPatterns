﻿#region

using System;

#endregion

namespace 适配器模式_日志_类适配器 {
    internal class DatabaseLog : LogAdaptee {
        public override void WriteLog() {
            Console.WriteLine("WriteLog -> DB");
        }
    }
}