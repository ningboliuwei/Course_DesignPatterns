#region

using System;

#endregion

namespace 原型模式_简历_内含对象深复制版 {
    internal class ExpInfo {
        public ExpInfo(string place, DateTime startDate, DateTime endDate) {
            Place = place;
            StartDate = startDate;
            EndDate = endDate;
        }

        public DateTime EndDate { get; set; }
        public string Place { get; set; }
        public DateTime StartDate { get; set; }
    }
}