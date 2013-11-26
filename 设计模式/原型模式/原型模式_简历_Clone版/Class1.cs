using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 原型模式_简历_Clone版
{
	using System.Collections;

	internal class Class1
	{
		public void Test()
		{
			ArrayList arrayList = new ArrayList();

			arrayList.Add("A");
			arrayList.Add("B");

			foreach (string s in arrayList)
			{
				Console.WriteLine(s);
			}

			ArrayList arrayList2 = arrayList.Clone() as ArrayList;

			arrayList[0] = "C";

			foreach (string s in arrayList)
			{
				Console.WriteLine(s);
			}

			foreach (string s in arrayList2)
			{
				Console.WriteLine(s);
			}
		}
	}
}