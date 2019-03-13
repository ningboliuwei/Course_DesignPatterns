using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验03_银行系统改进原版
{
    class CreditCardAccount : Account
    {
        //额度
        public double _limit;
        //积分
        public long _score;

        public CreditCardAccount(string id, string pwd, double limit)
            : base(id, pwd)
        {
            _limit = limit;
            _score = 0;
        }

        /// <summary>
        ///     额度属性
        /// </summary>
        public double Limit
        {
            get { return _limit; }
            set { _limit = value; }
        }

        /// <summary>
        ///     积分属性
        /// </summary>
        public long Score
        {
            get { return _score; }
            set { _score = value; }
        }

        /// <summary>
        ///     改变信用卡额度
        /// </summary>
        /// <param name="limit">新的额度</param>
        public void setLimit(double limit)
        {
            _limit = limit;
        }

        /// <summary>
        ///     获取信用卡额度
        /// </summary>
        /// <returns></returns>
        public double getLimit()
        {
            return _limit;
        }

        /// <summary>
        ///     改变积分
        /// </summary>
        /// <param name="score"></param>
        /// <returns></returns>
        public void setScore(long score)
        {
            _score = score;
        }

        /// <summary>
        ///     获取积分
        /// </summary>
        /// <returns></returns>
        public long getScore()
        {
            return _score;
        }


        public override bool WithdrawMoney(double money)
        {
            //若当前余额减去提取金额后仍多余或等于额度，那么允许消费
            if (_money - money >= -_limit)
            {
                _money -= money;
                return true;
            }
            return false;
        }


        /// <summary>
        ///     增加积分方法
        /// </summary>
        /// <param name="score"></param>
        /// <returns></returns>
        public bool AddScore(long score)
        {
            _score += score;
            return true;
        }

        /// <summary>
        ///     扣积分方法
        /// </summary>
        /// <param name="score"></param>
        /// <returns></returns>
        public bool ReduceScore(long score)
        {
            if (_score - score >= 0)
            {
                _score -= score;
                return true;
            }

            return false;
        }
    }
}
