using System;
using System.Collections.Generic;
using System.Text;
using 建造者模式_画小人_建造者模式版;

namespace 建造者模式_画小人_建造者模式_装配版
{
	internal class PersonDirector
	{
		private PersonBuilder _builder;

		public PersonDirector(PersonBuilder builder)
		{
			_builder = builder;
		}

		public Person CreatePerson()
		{
			_builder.BuildHead();
			_builder.BuildBody();
            _builder.BuildLeftArm();
			_builder.BuildRightArm();
			_builder.BuildLeftLeg();
			_builder.BuildRightLeg();

			return _builder.GetPerson();
		}
	}
}