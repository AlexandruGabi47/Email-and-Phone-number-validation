using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFProject
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public void CheckPhoneNumber(string phoneNumber) // 0700000000 is valid
		{
			if (phoneNumber.Length != 10)
				throw new Exception("Phone number length must contain 10 digits");
			if (!(phoneNumber[0] == '0' && phoneNumber[1] == '7'))
				throw new Exception("Invalid phone number");
		}
		
		public void CheckEMail(string email) // a@a.a is valid
		{
			string username = string.Empty;
			string domain = string.Empty;

			bool writeUsername = true;
			int amountOfAtSigns = 0;
			int amountOfDotsInDomain = 0;
			int indexOfDotSeparator;

			int minLength = 1;
			int maxNameLength = 64;
			int maxDomainLength = 188;
			// Verifying the email of invalid characters "(),:;<>@[\] and space
			if (email.Contains('\"') || email.Contains('(') || email.Contains(')') 
				|| email.Contains(',') || email.Contains(':') || email.Contains(';') 
				|| email.Contains('<') || email.Contains('>') || email.Contains('[') 
				|| email.Contains('\\') || email.Contains(']') || email.Contains(' '))
				throw new Exception("Invalid Email adress");
			// Email can't have more than one @
			for (int i = 0; i < email.Length - 1; i++)
				if (email[i] == '@')
					amountOfAtSigns++;

			if (amountOfAtSigns > 1 || amountOfAtSigns == 0)
				throw new Exception("Invalid Email adress");
			// Separating the email into the username and domain
			for (int i = 0; i < email.Length; i++)
			{
				if (email[i] == '@')
				{
					writeUsername = false;
					i++;
				}
				if (writeUsername)
					username += email[i];
				else
				{
					if (email[i] == '.')
					{
						amountOfDotsInDomain++;
						if (amountOfDotsInDomain > 1)
							throw new Exception("Invalid Email adress");
						indexOfDotSeparator = domain.Length;
					}
					domain += email[i];
				}
			}
			// Verifying length of name/domain
			if (username.Length > maxNameLength || domain.Length > maxDomainLength
				|| username.Length < minLength || domain.Length < minLength)
				throw new Exception("Invalid Email adress");
			// Veryfing the domain
			bool isBeforeDot = true;
			int charsBeforeDot = 0;
			int charsAfterDot = 0;
			if (!domain.Contains('.'))
				throw new Exception("Invalid domain name");
			for (int i = 0; i < domain.Length - 1; i++)
			{
				if (domain[i] == '.')
				{
					isBeforeDot = false;
					i++;
				}
				if (!char.IsLetterOrDigit(domain[i]))
					throw new Exception("Invalid domain name");
				if (isBeforeDot) charsBeforeDot++;
				else charsAfterDot++;
			}
			// Domain needs at least one letter before the dot and after 'a.a'
			if (!(charsBeforeDot >= 1 && charsAfterDot >= 1))
				throw new Exception("Invalid domain name");
		}

		private void ApplyButton_Click(object sender, EventArgs e)
		{
			try
			{
				CheckEMail(EmailTextBox.Text);
				CheckPhoneNumber(PhoneNumberTextBox.Text);

				ValidationLabel.ForeColor = Color.Green;
				ValidationLabel.Text = "Success";
			}
			catch (Exception error)
			{
				ValidationLabel.ForeColor = Color.Red;
				ValidationLabel.Text = error.Message;
			}
		}

		private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
				e.Handled = true;
		}
	}
}
