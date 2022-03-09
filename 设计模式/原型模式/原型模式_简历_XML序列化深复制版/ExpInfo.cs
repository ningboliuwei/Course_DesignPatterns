#region

using System;

#endregion

namespace 原型模式_简历_XML序列化深复制版 {
    [Serializable]
    public class ExpInfo {
        public ExpInfo() {
        }

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