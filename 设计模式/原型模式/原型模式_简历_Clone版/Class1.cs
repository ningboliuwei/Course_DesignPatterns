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
			ArrayList arrayList1 = new ArrayList();

			arrayList1.Add("A");
			arrayList1.Add("B");

			Console.WriteLine("Clone之前的ArrayList1");
			foreach (string s in arrayList1)
			{
				Console.WriteLine(s);
			}
			//ICloneable ic;
			//ic = arrayList1;


			ArrayList arrayList2 = arrayList1.Clone() as ArrayList;
			//ArrayList arrayList2 = arrayList1;
			
			Console.WriteLine("Clone出来的ArrayList2");
			foreach (string s in arrayList2)
			{
				Console.WriteLine(s);
			}

			Console.WriteLine("修改之后的ArrayList1");
			arrayList1[0] = "C";

			foreach (string s in arrayList1)
			{
				Console.WriteLine(s);
			}

			Console.WriteLine("修改之后的ArrayList2");
			foreach (string s in arrayList2)
			{
				Console.WriteLine(s);
			}
		}
	}
}