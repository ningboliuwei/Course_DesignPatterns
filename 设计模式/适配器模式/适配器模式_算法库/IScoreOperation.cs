using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 适配器模式_算法库
{
	interface IScoreOperation
	{
		int[] Sort(int[] array); //成绩排序  
		int Search(int[] array, int key); //成绩查找  
	}
}
