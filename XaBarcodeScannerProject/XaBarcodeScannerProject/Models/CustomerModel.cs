using System;
using System.Collections.Generic;
using System.Text;

namespace XaBarcodeScannerProject.Models
{
  public  class CustomerModel
    {
		private int id;

		public int ID
		{
			get { return id; }
			set { id = value; }
		}


		private string firstName;

		public string FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}

		private string password;

		public string Password
		{
			get { return password; }
			set { password = value; }
		}

		private string email;

		public string Email
		{
			get { return email; }
			set { email = value; }
		}

		private string lastname;

		public string Lastname
		{
			get { return lastname; }
			set { lastname = value; }
		}
		
	}
}
