using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApps
{
	
   public class Project
	{
		/// <summary>
		/// Список из объектов класса Contact
		/// </summary>
		public List<Contact> _contactlist;
		public Project()
		{
		
			_contactlist = new List<Contact>(200);
		}

	}
}
