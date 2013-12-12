using System;
using System.Collections.Generic;
using System.Text;

namespace 命令模式_计算器_命令模式
{
	public class CaculatorCommand : Command
	{
		private char m_optr;

		private int m_operand;

		private Caculator m_caculator;

		public CaculatorCommand(Caculator mCaculator, char mOptr, int mOperand)
		{
			this.m_optr = mOptr;
			this.m_operand = mOperand;
			this.m_caculator = mCaculator;
		}

		public char Optr
		{
			set
			{
				this.m_optr = value;
			}
		}

		public int Operand
		{
			set
			{
				this.m_operand = value;
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
			this.m_caculator.Operaion(this.m_optr, this.m_operand);
		}

		public override void UnExecute()
		{
			this.m_caculator.Operaion(Undo(this.m_optr), this.m_operand);
		}
	}
}