using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApps
{
	/// <summary>
	/// Класс, содержащий номер телефона.
	/// </summary>
	public class Phone
	{
		private long _number;
		public long Number
		{
			get { return _number; }
			set
			{
				if (value < 0)
				{
					throw new ArgumentException("Номер телефона не может быть отрицательным");
				}
				else if ((value / 10000000000) != 7)
				{
					throw new ArgumentException("Номер телефона должен начинаться с 7 ");
				}
				else
					_number = value;
			}
		}
	}

}






