using System;
using System.Collections.Generic;
using System.Text;

namespace 建造者模式_画小人_建造者模式_单小人版
{
	class PersonDirector
	{
		private PersonBuilder _builder;

		public PersonDirector(PersonBuilder builder)
		{
			_builder = builder;
		}

		public void CreatePerson()
		{
			_builder.BuildHead();
			_builder.BuildBody();
			_builder.BuildLeftArm();
			_builder.BuildRightArm();
			_builder.BuildLeftLeg();
			_builder.BuildRightLeg();
		}
	}
}