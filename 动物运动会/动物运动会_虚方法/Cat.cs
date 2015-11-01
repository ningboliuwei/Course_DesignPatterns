﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 动物运动会_虚方法
{
	internal class Cat : Animal
	{
		public Cat()
			: base()
		{
		}

		public Cat(string name)
			: base(name)
		{
		}


        public override  string Shout()
        {
            string resultStr = "";
            resultStr += "我是" + name + "，";

            for (int i = 0; i < shoutNum; i++)
            {
                resultStr += "喵~";
            }
            return resultStr;
        }


       
    }
}