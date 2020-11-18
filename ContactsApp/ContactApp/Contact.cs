using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactsApps;


namespace ContactsApps
{
	/// <summary>
	/// класс, содержащий 6 полей: фамилия, имя, номер тел, дата рождения, mail, idвк
	/// </summary>

	//public class Phone

	//	private string 

	public class Contact
	{
		private string _lastname;
		private string _name;
		private Phone _number;
		private DateTime _birthdate;
		private string _email;
		private string _vkid;
		/// <summary>
		/// фамилия с ограничением в 50 символов
		/// </summary>
		public string Lastname
		{
			get { return _lastname; }
			set
			{

				if (value.Length > 50)
				{
					throw new ArgumentException("максимальное число имволов 50");
				}
				else
				{
					{
						_lastname = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
					}
				}
			}
		}
		/// <summary>
		/// имя с ограничением в 50 символов
		/// </summary>
		public string Name
		{
			get { return _name; }
			set
			{
				if (value.Length > 50)
				{
					throw new ArgumentException("максимальное количество символов  50");
				}
				else
				{
					{
						_name = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
					}
				}
			}
		}
		/// <summary>
		/// номер телефона контакта
		/// </summary>
		public Phone Number
		{
			get { return _number; }
			set
			{
				_number = value;
			}
		}
		/// <summary>
		/// дата рождения контакта, год не может быть больше текущей даты и меньше 1900
		/// </summary>
		public DateTime Birthdate
		{
			get { return _birthdate; }
			set
			{
				if (value.Year < 1900 || value > DateTime.Now)
					throw new ArgumentException("дата должна быть не меньше 1900 и нне больше текущей");
				else
					_birthdate = value;
			}
		}
		/// <summary>
		/// электронная почта контакта с ограничением в 50 символов
		/// </summary>
		public string Email
		{
			get { return _email; }
			set
			{
				if (value.Length > 50)
				{
					throw new ArgumentException("максимальное количество символов 50");
				}
				else
				{
					_email = value;
				}
			}
		}
		/// <summary>
		/// вкID с ограничением в 15 символов
		/// </summary>
		public string VKid
		{
			get
			{
				return _vkid;
			}
			set
			{
				if (value.Length > 15)
				{
					throw new ArgumentException("число символов должно быть 15");
				}
				else
				{
					_vkid = value;
				}
			}
		}
	}
}
			
		

