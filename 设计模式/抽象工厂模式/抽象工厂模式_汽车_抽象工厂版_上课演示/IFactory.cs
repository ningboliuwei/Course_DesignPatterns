using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象工厂模式_汽车_抽象工厂版_上课演示
{
	internal interface IFactory
	{
		Engine GetEngine();

		Dynamo GetDynamo();
	}
}