using System;
using System.Collections.Generic;
using System.Text;

namespace 原型模式_简历_Clone版
{
	internal class Resume : ICloneable
	{
		private string _name;

		private string _sex;

		private string _age;

		private string _timeArea;

		private string _company;

		public Resume(string name)
		{
			this._name = name;
		}

		public void SetPersonalInfo(string sex, string age)
		{
			this._sex = sex;
			this._age = age;
		}

		public void SetWorkExperience(string timeArea, string company)
		{
			this._timeArea = timeArea;
			this._company = company;
		}

		public void Display()
		{
			Console.WriteLine("{0} {1} {2}", _name, _sex, _age);
			Console.WriteLine("工作经历：{0} {1}", _timeArea, _company);
		}

		public object Clone()
		{
			return this.MemberwiseClone();
		}
	}
}