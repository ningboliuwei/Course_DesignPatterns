using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 迭代器模式_NET_IEnumerable
{
	using System.Collections;

	internal class PersonArray : IEnumerable
	{
		private Person[] array;

		public PersonArray(Person[] array)
		{
			this.array = array;
		}

		public IEnumerator GetEnumerator()
		{
			return new PersonEnumerator(array);
		}
	}
}