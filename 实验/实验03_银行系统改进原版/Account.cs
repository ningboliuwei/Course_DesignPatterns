using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验03_银行系统改进原版
{
    public class Account
    {
        protected string _id;
        protected double _money; //decimal money;
        protected string _pwd;
        //string name;

        public Account()
        {
        }

        public Account(string id, string pwd)
        {
            _id = id;
            _pwd = pwd;
            _money = 0;
        }

        public double getMoney()
        {
            return _money;
        }

        public void setMoney(double val)
        {
            _money = val;
        }

        public string getId()
        {
            return _id;
        }

        public void setId(string id)
        {
            _id = id;
        }

        public string getPwd()
        {
            return _pwd;
        }

        public void setPwd(string pwd)
        {
            _pwd = pwd;
        }

        public bool SaveMoney(double money)
        {
            if (money < 0) return false; //卫语句

            _money += money;
            return true;
        }

        public virtual bool WithdrawMoney(double money)
        {
            if (_money >= money)
            {
                _money -= money;
                return true;
            }

            return false;
        }

        public bool IsMatch(string id, string pwd)
        {
            return id == _id && pwd == _pwd;
        }
    }
}
