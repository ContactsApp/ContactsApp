using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApps;

namespace ContactsAppUI
{

	public partial class Main_Form : Form
	{
		private const long V = 79998887766;
		public Project project;


		public Main_Form()
		{

		}

		private void Main_Form_Load(object sender, EventArgs e)
		{
			//InitializeComponent();

			project = new Project();

			Phone phone = new Phone();
			phone.Number = 78654756521;

			Contact contact = new Contact();
			contact.Name = "jenya";
			contact.Lastname = "vAsin";
			contact.Number = phone;
			contact.VKid = "345126";
			contact.Birthdate = new DateTime(2001, 16, 7);
			contact.Email = "123qwerty@mail.ru";

			//textBox1.Text = contact.Lastname;
			//textBox2.Text = contact.Name;

			project._contactlist.Add(contact);

		}
	}
}
