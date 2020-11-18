using System;
using System.Collections.Generic;
using System.Text;

namespace ContactsApp
{
	/// <summary>
	/// класс с номером телефона
	/// </summary>
	public class Phone
	{
		private int _number;


		public int Number
		{
			get { return _number; }
			set
			{
				if (value < 0)
				{
					throw new ArgumentException("номер не может быть меньше нуля!!");
				}
				else if ((value / 10000000000) != 7)
				{
					throw new ArgumentException("номер должен начинаться с 7!!");
				}
				else
					_number = value;
			}
		}
	}

}






