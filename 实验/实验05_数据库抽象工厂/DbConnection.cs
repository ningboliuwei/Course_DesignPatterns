using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验05_数据库抽象工厂
{
    class DbConnection
    {
        public string ConnectionString { get; set; }

        public virtual void Open()
        {
        }

        public virtual void Close()
        {
        }
    }
}