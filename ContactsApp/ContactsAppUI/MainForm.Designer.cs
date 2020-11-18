
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;
using ContactsApps;

namespace ContactsAppUI
{

	public partial class Main_Form : Form
	{
		public Project project;


		public Main_Form()
		{

		}

		private void ClassLoad(object sender, EventArgs e)
		{
			//InitializeComponent();

			project = new Project();

			Phone phone = new Phone();
			//phone.Number = +79998887766;

			Contact contact = new Contact();
			contact.Name = "petya";
			contact.Lastname = "pEtRoVS";
			contact.Number = phone;
			contact.VKid = "12456";
			contact.Birthdate = new DateTime(2000, 12, 3);
			contact.Email = "mail@mail.ru";

			//textBox1.Text = contact.Lastname;
			//textBox2.Text = contact.Name;

			project._contactlist.Add(contact);

		}
	}
}