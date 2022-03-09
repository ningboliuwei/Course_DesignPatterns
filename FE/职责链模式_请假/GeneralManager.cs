#region

using System;

#endregion

namespace 职责链模式_请假_职责链模式 {
    public class GeneralManager : Manager {
        public GeneralManager(string name)
            : base(name) {
        }

        public override void HandleApplications(Application application) {
            if (application.DayCount < 30) {
                Console.WriteLine("{0}:{1}的申请 数量{2} 被批准", _name, application.Name, application.DayCount);
            }
            else {
                Console.WriteLine("{0}:{1}的申请 数量{2} 被拒绝", _name, application.Name, application.DayCount);
            }
        }
    }
}