using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验03_银行系统改进
{
    interface IValidatable
    {
        bool Validate(string id, string password);
    }
}
