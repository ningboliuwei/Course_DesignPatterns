﻿using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式_加班_使用类版
{
    using System.Data;
    using System.Data.SqlClient;

    //工作
    public class Work
    {
        //钟点
        private int m_hour;

        public int Hour {
            get { return m_hour; }
            set { m_hour = value; }
        }

        //任务完成
        private bool m_taskFinished;

        public bool TaskFinished {
            get { return m_taskFinished; }
            set { m_taskFinished = value; }
        }

        public void WriteProgram() {
            if (m_hour < 12) {
                Console.WriteLine("当前时间：{0}点 上午工作，精神百倍", m_hour);
            }
            else if (m_hour < 13) {
                Console.WriteLine("当前时间：{0}点 饿了，午饭；犯困，午休。", m_hour);
            }
            else if (m_hour < 17) {
                Console.WriteLine("当前时间：{0}点 下午状态还不错，继续努力", m_hour);
            }
            else {
                if (m_taskFinished) {
                    Console.WriteLine("当前时间：{0}点 下班回家了", m_hour);
                }
                else {
                    if (m_hour < 21) {
                        Console.WriteLine("当前时间：{0}点 加班哦，疲累之极", m_hour);
                    }
                    else {
                        Console.WriteLine("当前时间：{0}点 不行了，睡着了。", m_hour);
                    }
                }
            }
        }
    }
}