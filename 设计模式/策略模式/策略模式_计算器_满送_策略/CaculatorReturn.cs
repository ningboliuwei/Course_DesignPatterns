#region

using System;

#endregion

namespace 策略模式_计算器_满送_策略 {
    internal class CaculatorReturn : ICaculator {
        private readonly double _priceCondition;
        private readonly double _priceReturn;

        public CaculatorReturn(double priceCondition, double priceReturn) {
            _priceCondition = priceCondition;
            _priceReturn = priceReturn;
        }

        public override double CaculatePrice(double originalPrice) {
            var result = originalPrice;

            if (originalPrice >= _priceCondition) {
                result = originalPrice - Math.Floor(originalPrice / _priceCondition) * _priceReturn;
            }

            return result;
        }
    }
}