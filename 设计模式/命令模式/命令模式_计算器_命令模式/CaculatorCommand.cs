using System;
using System.Collections.Generic;
using System.Text;

namespace 命令模式_计算器_命令模式
{
	public class CaculatorCommand : Command
	{
		private char _optr;

		private int _operand;

		private Caculator _caculator;

		public CaculatorCommand(Caculator caculator, char optr, int operand)
		{
			_optr = optr;
			_operand = operand;
			_caculator = caculator;
		}

		public char Optr
		{
			set
			{
				_optr = value;
			}
		}

		public int Operand
		{
			set
			{
				_operand = value;
			}
		}

		private char Undo(char optr)
		{
			char undo = ' ';

			switch (optr)
			{
				case '+':
					undo = '-';
					break;
				case '-':
					undo = '+';
					break;
				case '*':
					undo = '/';
					break;
				case '/':
					undo = '*';
					break;
			}

			return undo;
		}

		public override void Execute()
		{
			_caculator.Operaion(_optr, _operand);
		}

		public override void UnExecute()
		{
			_caculator.Operaion(Undo(_optr), _operand);
		}
	}
}