using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace 迭代器模式_NET_IEnumerable
{
	internal class PersonEnumerator : IEnumerator
	{
		private Person[] array;

		private int position;

		public PersonEnumerator(Person[] array)
		{
			this.array = array;
			this.position = -1;
		}

		public object Current
		{
			get
			{
				if (position > -1 && position < array.Length)
				{
					return array[position];
				}
				else
				{
					throw new IndexOutOfRangeException();
				}
			}
		}

		public bool MoveNext()
		{
			position++;
			return position < array.Length;
		}

		public void Reset()
		{
			position = -1;
		}
	}
}